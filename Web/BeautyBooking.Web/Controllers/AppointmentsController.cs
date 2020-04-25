namespace BeautyBooking.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Services.DateTimeParser;
    using BeautyBooking.Web.ViewModels.Appointments;
    using BeautyBooking.Web.ViewModels.SalonServices;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AppointmentsController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDateTimeParserService dateTimeParserService;
        private readonly ISalonsService salonsService;
        private readonly IAppointmentsService appointmentsService;
        private readonly ISalonServicesService salonServicesService;

        public AppointmentsController(
            UserManager<ApplicationUser> userManager,
            IAppointmentsService appointmentsService,
            ISalonServicesService salonServicesService,
            IDateTimeParserService dateTimeParserService,
            ISalonsService salonsService)
        {
            this.userManager = userManager;
            this.appointmentsService = appointmentsService;
            this.salonServicesService = salonServicesService;
            this.dateTimeParserService = dateTimeParserService;
            this.salonsService = salonsService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetUpcomingByUserAsync<AppointmentViewModel>(userId),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> MakeAnAppointment(string salonId, int serviceId)
        {
            var salonService = await this.salonServicesService.GetByIdAsync<SalonServiceSimpleViewModel>(salonId, serviceId);
            if (salonService == null || !salonService.Available)
            {
                return this.View("UnavailableService");
            }

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

            DateTime dateTime;
            try
            {
                dateTime = this.dateTimeParserService.ConvertStrings(input.Date, input.Time);
            }
            catch (System.Exception)
            {
                return this.RedirectToAction("MakeAnAppointment", new { input.SalonId, input.ServiceId });
            }

            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            await this.appointmentsService.AddAsync(userId, input.SalonId, input.ServiceId, dateTime);

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CancelAppointment(string id)
        {
            var viewModel = await this.appointmentsService.GetByIdAsync<AppointmentViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
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
                return this.RedirectToAction("RatePastAppointment", new { id = rating.Id });
            }

            if (rating.IsSalonRatedByTheUser == true)
            {
                return this.RedirectToAction("RatePastAppointment", new { id = rating.Id });
            }

            await this.appointmentsService.RateAppointmentAsync(rating.Id);
            await this.salonsService.RateSalonAsync(rating.SalonId, rating.RateValue);

            return this.RedirectToAction("Details", "Salons", new { id = rating.SalonId });
        }
    }
}
