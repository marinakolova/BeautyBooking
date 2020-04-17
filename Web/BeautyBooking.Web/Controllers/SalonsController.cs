namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons =
                    this.salonsService.GetAll<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var viewModel = this.salonsService.GetById<SalonDetailsViewModel>(id);
            return this.View(viewModel);
        }
    }
}
