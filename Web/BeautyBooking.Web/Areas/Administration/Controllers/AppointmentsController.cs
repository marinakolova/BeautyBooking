namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class AppointmentsController : AdministrationController
    {
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetAllAsync<AppointmentViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
