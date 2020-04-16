namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Blog;
    using BeautyBooking.Web.ViewModels.Administration.Blog;
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : AdministrationController
    {
        private readonly IBlogPostsService blogPostsService;

        public BlogController(IBlogPostsService blogPostsService)
        {
            this.blogPostsService = blogPostsService;
        }

        public IActionResult Index()
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts =
                    this.blogPostsService.GetAll<BlogPostViewModel>(),
            };
            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult AddBlogPost()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost(BlogPostInputModel input)
        {
            await this.blogPostsService.AddBlogPostAsync(input.Title, input.Content, input.Author, input.ImageUrl);

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            await this.blogPostsService.DeleteBlogPostAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
