namespace BeautyBooking.Web.Areas.Manager.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Manager.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : ManagerBaseController
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

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonDetailsViewModel>(id);

            return this.View(viewModel);
        }
    }
}
