namespace BeautyBooking.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
