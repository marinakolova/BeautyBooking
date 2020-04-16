namespace BeautyBooking.Web.Controllers
{
    using BeautyBooking.Services.Data;
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
            var viewModel = new IndexViewModel
            {
                BlogPosts =
                    this.blogPostsService.GetAll<IndexBlogViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
