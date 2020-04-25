namespace BeautyBooking.Web.Areas.Manager.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : ManagerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly ISalonServicesService salonServicesService;
        private readonly IAppointmentsService appointmentsService;

        public SalonsController(
            ISalonsService salonsService,
            ISalonServicesService salonServicesService,
            IAppointmentsService appointmentsService)
        {
            this.salonsService = salonsService;
            this.salonServicesService = salonServicesService;
            this.appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonWithServicesViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeServiceAvailableStatus(string salonId, int serviceId)
        {
            await this.salonServicesService.ChangeAvailableStatusAsync(salonId, serviceId);

            return this.RedirectToAction("Details", new { id = salonId });
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(string id, string salonId)
        {
            await this.appointmentsService.ConfirmAsync(id);
            return this.RedirectToAction("Details", new { id = salonId });
        }

        [HttpPost]
        public async Task<IActionResult> DeclineAppointment(string id, string salonId)
        {
            await this.appointmentsService.DeclineAsync(id);
            return this.RedirectToAction("Details", new { id = salonId });
        }
    }
}
