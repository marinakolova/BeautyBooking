namespace BeautyBooking.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class AppointmentsViewComponent : ViewComponent
    {
        private readonly ISalonServicesService salonServicesService;

        public AppointmentsViewComponent(ISalonServicesService salonServicesService)
        {
            this.salonServicesService = salonServicesService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId, int serviceId)
        {
            var viewModel = await this.salonServicesService.GetByIdAsync<SalonServiceViewModel>(salonId, serviceId);

            // TODO:
            return this.View(viewModel);
        }
    }
}
