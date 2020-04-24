namespace BeautyBooking.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class AllAppointmentsBySalonViewComponent : ViewComponent
    {
        private readonly IAppointmentsService appointmentsService;

        public AllAppointmentsBySalonViewComponent(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId)
        {
            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetAllBySalonAsync<AppointmentViewModel>(salonId),
            };

            return this.View(viewModel);
        }
    }
}
