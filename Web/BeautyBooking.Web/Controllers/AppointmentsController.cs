namespace BeautyBooking.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AppointmentsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
