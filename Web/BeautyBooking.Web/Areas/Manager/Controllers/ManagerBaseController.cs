namespace BeautyBooking.Web.Areas.Manager.Controllers
{
    using BeautyBooking.Common;
    using BeautyBooking.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.SalonManagerRoleName)]
    [Area("Manager")]
    public class ManagerBaseController : BaseController
    {
    }
}
