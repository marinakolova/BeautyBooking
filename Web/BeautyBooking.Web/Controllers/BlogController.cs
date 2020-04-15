namespace BeautyBooking.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
