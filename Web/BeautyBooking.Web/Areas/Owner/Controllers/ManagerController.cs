namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data;
    using BeautyBooking.Web.ViewModels.Administration.Dashboard;
    using Microsoft.AspNetCore.Mvc;

    public class ManagerController : OwnerController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
