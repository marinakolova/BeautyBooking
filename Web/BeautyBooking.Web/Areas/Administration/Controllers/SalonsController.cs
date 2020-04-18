namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Administration.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : AdministrationController
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

        public async Task<IActionResult> DeleteSalon(int id)
        {
            await this.salonsService.DeleteSalonAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
