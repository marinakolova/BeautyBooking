namespace BeautyBooking.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
