namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System.Collections.Generic;

    public class AppointmentsListViewModel
    {
        public IEnumerable<AppointmentViewModel> Appointments { get; set; }
    }
}
