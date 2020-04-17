namespace BeautyBooking.Web.Controllers
{
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

        public IActionResult Index()
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts =
                    this.blogPostsService.GetAll<BlogPostViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var viewModel = this.blogPostsService.GetById<BlogPostViewModel>(id);
            return this.View(viewModel);
        }
    }
}
