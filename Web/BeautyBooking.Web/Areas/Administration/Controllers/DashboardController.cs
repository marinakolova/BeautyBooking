namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data;
    using BeautyBooking.Web.ViewModels.Administration.Dashboard;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly ISettingsService settingsService;
        private readonly ICategoriesService categoriesService;
        private readonly IBlogPostsService blogPostsService;

        public DashboardController(ISettingsService settingsService, ICategoriesService categoriesService, IBlogPostsService blogPostsService)
        {
            this.settingsService = settingsService;
            this.categoriesService = categoriesService;
            this.blogPostsService = blogPostsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel { SettingsCount = this.settingsService.GetCount(), };
            return this.View(viewModel);
        }

        // CATEGORIES
        public IActionResult Categories()
        {
            var viewModel = new AdminCategoriesViewModel
            {
                Categories =
                    this.categoriesService.GetAll<AdminCategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInputModel input)
        {
            await this.categoriesService.AddCategoryAsync(input.Name, input.Description, input.ImageUrl);

            return this.RedirectToAction("Categories");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await this.categoriesService.DeleteCategoryAsync(id);

            return this.RedirectToAction("Categories");
        }

        // BLOG
        public IActionResult Blog()
        {
            var viewModel = new AdminBlogPostsListViewModel
            {
                BlogPosts =
                    this.blogPostsService.GetAll<AdminBlogPostViewModel>(),
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

            return this.RedirectToAction("Blog");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            await this.blogPostsService.DeleteBlogPostAsync(id);

            return this.RedirectToAction("Blog");
        }

        // SALONS
        public IActionResult Salons()
        {
            return this.View();
        }
    }
}
