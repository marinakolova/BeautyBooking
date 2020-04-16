namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using BeautyBooking.Common;
    using BeautyBooking.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.SalonOwnerRoleName)]
    [Area("Owner")]
    public class OwnerBaseController : BaseController
    {
    }
}
