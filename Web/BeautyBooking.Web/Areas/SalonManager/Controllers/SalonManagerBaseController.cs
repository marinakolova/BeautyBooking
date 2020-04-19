namespace BeautyBooking.Web.Areas.SalonManager.Controllers
{
    using BeautyBooking.Common;
    using BeautyBooking.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.SalonManagerRoleName + "," + GlobalConstants.AdministratorRoleName)]
    [Area("SalonManager")]
    public class SalonManagerBaseController : BaseController
    {
    }
}
