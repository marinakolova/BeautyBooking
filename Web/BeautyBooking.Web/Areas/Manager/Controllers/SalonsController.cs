namespace BeautyBooking.Web.Areas.Manager.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Manager.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : ManagerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly IAppointmentsService appointmentsService;

        public SalonsController(ISalonsService salonsService, IAppointmentsService appointmentsService)
        {
            this.salonsService = salonsService;
            this.appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonDetailsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(int id)
        {
            await this.appointmentsService.Confirm(id);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeclineAppointment(int id)
        {
            await this.appointmentsService.Decline(id);
            return this.RedirectToAction("Index");
        }
    }
}
