namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AppointmentsController : BaseController
    {
        private readonly IAppointmentsService appointmentsService;
        private readonly ISalonsService salonsService;
        private readonly UserManager<ApplicationUser> userManager;

        public AppointmentsController(
            IAppointmentsService appointmentsService,
            ISalonsService salonsService,
            UserManager<ApplicationUser> userManager)
        {
            this.appointmentsService = appointmentsService;
            this.salonsService = salonsService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new AppointmentsListViewModel
            {
                Appointments = await this.appointmentsService.GetUpcomingByUserAsync<AppointmentViewModel>(userId),
            };
            return this.View(viewModel);
        }

        public IActionResult MakeAnAppointment(string salonId, int serviceId)
        {
            var viewModel = new AppointmentInputModel
            {
                SalonId = salonId,
                ServiceId = serviceId,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> MakeAnAppointment(AppointmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("MakeAnAppointment", new { input.SalonId, input.ServiceId });
            }

            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            await this.appointmentsService.AddAsync(userId, input.SalonId, input.ServiceId, input.Date, input.Time);

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CancelAppointment(string id)
        {
            var viewModel = await this.appointmentsService.GetByIdAsync<AppointmentViewModel>(id);

            if (viewModel == null)
            {
                return this.RedirectToAction("Index");
            }

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAppointment(string id)
        {
            await this.appointmentsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> RatePastAppointment(string id)
        {
            var viewModel = await this.appointmentsService.GetByIdAsync<AppointmentRatingViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RateSalon(AppointmentRatingViewModel rating)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("RatePastAppointment", new { rating.Id });
            }

            if (rating.IsSalonRatedByTheUser == true)
            {
                return this.RedirectToAction("RatePastAppointment", new { rating.Id });
            }

            await this.appointmentsService.RateAppointment(rating.Id);
            await this.salonsService.RateSalon(rating.SalonId, rating.RateValue);

            var id = rating.SalonId; // Redirection doesn't work with rating.SalonId;
            return this.RedirectToAction("Details", "Salons", new { id });
        }
    }
}
