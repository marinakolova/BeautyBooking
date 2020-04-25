namespace BeautyBooking.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Services.Data.BlogPosts;
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Web.ViewModels;
    using BeautyBooking.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IBlogPostsService blogPostsService;

        public HomeController(
            ICategoriesService categoriesService,
            IBlogPostsService blogPostsService)
        {
            this.categoriesService = categoriesService;
            this.blogPostsService = blogPostsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories =
                    await this.categoriesService.GetAllAsync<IndexCategoryViewModel>(
                        GlobalConstants.SeededDataCounts.Categories),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [Route("/Home/Error/404")]
        public IActionResult Error404()
        {
            return this.View();
        }

        [Route("/Home/Error/{code:int}")]
        public IActionResult Error(int code)
        {
            // Could handle different codes here
            // or just return the default error view
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
