namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Blog;
    using BeautyBooking.Web.ViewModels.Blog;
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : BaseController
    {
        private readonly IBlogPostsService blogPostsService;

        public BlogController(IBlogPostsService blogPostsService)
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
            var viewModel = await this.blogPostsService.GetByIdAsync<BlogPostViewModel>(id);

            return this.View(viewModel);
        }
    }
}
