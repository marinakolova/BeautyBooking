namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Services.Cloudinary;
    using BeautyBooking.Services.Data.BlogPosts;
    using BeautyBooking.Web.ViewModels.BlogPosts;
    using Microsoft.AspNetCore.Mvc;

    public class BlogPostsController : AdministrationController
    {
        private readonly IBlogPostsService blogPostsService;
        private readonly ICloudinaryService cloudinaryService;

        public BlogPostsController(
            IBlogPostsService blogPostsService,
            ICloudinaryService cloudinaryService)
        {
            this.blogPostsService = blogPostsService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts = await this.blogPostsService.GetAllAsync<BlogPostViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddBlogPost()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost(BlogPostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Title);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.blogPostsService.AddAsync(input.Title, input.Content, input.Author, imageUrl);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.BlogPosts)
            {
                return this.RedirectToAction("Index");
            }

            await this.blogPostsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
