namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using BeautyBooking.Services.Data.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class AppointmentsController : AdministrationController
    {
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public IActionResult Index()
        {
            var viewModel = this.appointmentsService.GetAllAppointmentsCount();
            return this.View(viewModel);
        }
    }
}
