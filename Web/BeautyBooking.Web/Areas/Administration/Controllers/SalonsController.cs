namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using BeautyBooking.Services.Data.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService salonsService;

        public SalonsController(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public IActionResult Salons()
        {
            return this.View();
        }
    }
}
