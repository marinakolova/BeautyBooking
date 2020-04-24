namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Categories;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;

        public SalonsController(
            ISalonsService salonsService,
            ICategoriesService categoriesService)
        {
            this.salonsService = salonsService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> ByCategory(int id)
        {
            var viewModel = new SalonsByCategoryListViewModel();
            var category = await this.categoriesService.GetByIdAsync<CategorySimpleViewModel>(id);
            if (category == null)
            {
                return new StatusCodeResult(404);
            }
            else
            {
                viewModel.CategoryName = category.Name;
                viewModel.SalonsCount = category.SalonsCount;
                viewModel.Salons = await this.salonsService.GetAllByCategoryAsync<SalonViewModel>(id);
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonWithServicesViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404); // TODO: 404 NotFound Page
            }

            return this.View(viewModel);
        }
    }
}
