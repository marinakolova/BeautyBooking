namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Owner.SalonManager;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class SalonManagerController : OwnerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly UserManager<ApplicationUser> userManager;

        public SalonManagerController(ISalonsService salonsService, UserManager<ApplicationUser> userManager)
        {
            this.salonsService = salonsService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new SalonsListViewModel
            {
                Salons =
                    this.salonsService.GetByOwner<SalonViewModel>(userId),
            };
            return this.View(viewModel);
        }
    }
}
