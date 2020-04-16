namespace BeautyBooking.Web.Controllers
{
    using BeautyBooking.Services.Data.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        private readonly ISalonsService salonsService;

        public SalonsController(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
