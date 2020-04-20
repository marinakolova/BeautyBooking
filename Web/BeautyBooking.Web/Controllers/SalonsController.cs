namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        private readonly ISalonsService salonsService;
        private readonly UserManager<ApplicationUser> userManager;

        public SalonsController(ISalonsService salonsService, UserManager<ApplicationUser> userManager)
        {
            this.salonsService = salonsService;
            this.userManager = userManager;
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
