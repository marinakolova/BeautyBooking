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

        public DashboardController(ISettingsService settingsService, ICategoriesService categoriesService)
        {
            this.settingsService = settingsService;
            this.categoriesService = categoriesService;
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

        // SALONS
        public IActionResult Salons()
        {
            return this.View();
        }

        // BLOG
        public IActionResult Blog()
        {
            return this.View();
        }
    }
}
