namespace BeautyBooking.Web.Controllers
{
    using System.Diagnostics;

    using BeautyBooking.Services.Data.Blog;
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Web.ViewModels;
    using BeautyBooking.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IBlogPostsService blogPostsService;

        public HomeController(ICategoriesService categoriesService, IBlogPostsService blogPostsService)
        {
            this.categoriesService = categoriesService;
            this.blogPostsService = blogPostsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories =
                    this.categoriesService.GetAll<IndexCategoryViewModel>(),
                BlogPosts =
                    this.blogPostsService.GetAll<IndexBlogViewModel>(4),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
