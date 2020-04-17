namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Administration.Salons;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService salonsService;

        public SalonsController(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
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

        [HttpGet]
        public async Task<IActionResult> DeleteSalon(int id)
        {
            await this.salonsService.DeleteSalonAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
