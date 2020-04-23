namespace BeautyBooking.Web.Areas.Manager.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Salons;
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

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonWithAppointmentsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(string id, string salon)
        {
            await this.appointmentsService.ConfirmAsync(id);
            return this.RedirectToAction("Details", new { id = salon });
        }

        [HttpPost]
        public async Task<IActionResult> DeclineAppointment(string id, string salon)
        {
            await this.appointmentsService.DeclineAsync(id);
            return this.RedirectToAction("Details", new { id = salon });
        }
    }
}
