namespace BeautyBooking.Web.Areas.SalonManager.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.SalonManager.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : SalonManagerBaseController
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
            var viewModel = await this.salonsService.GetByIdAsync<SalonViewModel>(id);

            return this.View(viewModel);
        }
    }
}
