namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using BeautyBooking.Common;
    using BeautyBooking.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
