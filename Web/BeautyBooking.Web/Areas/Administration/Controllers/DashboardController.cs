namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using BeautyBooking.Services.Data;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
