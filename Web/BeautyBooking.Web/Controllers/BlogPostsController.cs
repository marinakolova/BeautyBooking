namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.BlogPosts;
    using BeautyBooking.Web.ViewModels.BlogPosts;
    using Microsoft.AspNetCore.Mvc;

    public class BlogPostsController : BaseController
    {
        private readonly IBlogPostsService blogPostsService;

        public BlogPostsController(IBlogPostsService blogPostsService)
        {
            this.blogPostsService = blogPostsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts = await this.blogPostsService.GetAllAsync<BlogPostViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var allPostsCount = await this.blogPostsService.GetCountAsync();
            this.ViewData["AllPostsCount"] = allPostsCount;

            var viewModel = await this.blogPostsService.GetByIdAsync<BlogPostDetailsViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
