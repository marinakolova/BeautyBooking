namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        private readonly ISalonsService salonsService;

        public SalonsController(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
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
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllByCategoryAsync<SalonViewModel>(id),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonDetailsViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404); // TODO: 404 NotFound Page
            }

            return this.View(viewModel);
        }
    }
}
