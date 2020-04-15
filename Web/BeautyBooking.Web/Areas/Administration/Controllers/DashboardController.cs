namespace BeautyBooking.Web.Areas.Administration.Controllers
{
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

        public IActionResult Categories()
        {
            var viewModel = new AdminCategoriesViewModel
            {
                Categories =
                    this.categoriesService.GetAll<AdminCategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Salons()
        {
            return this.View();
        }

        public IActionResult Blog()
        {
            return this.View();
        }
    }
}
