namespace BeautyBooking.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CalendarController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
