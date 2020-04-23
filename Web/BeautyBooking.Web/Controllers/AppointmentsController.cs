namespace BeautyBooking.Web.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AppointmentsController : BaseController
    {
        private readonly IAppointmentsService appointmentsService;
        private readonly ISalonServicesService salonServicesService;
        private readonly UserManager<ApplicationUser> userManager;

        public AppointmentsController(
            IAppointmentsService appointmentsService,
            ISalonServicesService salonServicesService,
            UserManager<ApplicationUser> userManager)
        {
            this.appointmentsService = appointmentsService;
            this.salonServicesService = salonServicesService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new AppointmentsListViewModel
            {
                UpcomingAppointments = await this.appointmentsService.GetUpcomingByUserAsync<AppointmentViewModel>(userId),
                PastAppointments = await this.appointmentsService.GetPastByUserAsync<AppointmentViewModel>(userId),
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
        public IActionResult CancelAppointmentConfirm(string id)
        {
            // TODO: Are you sure? Page
            return this.View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CancelAppointment(string id)
        {
            await this.appointmentsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
