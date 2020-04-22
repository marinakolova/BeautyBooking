namespace BeautyBooking.Web.ViewModels.Administration.Appointments
{
    using System.Collections.Generic;

    public class AppointmentsListViewModel
    {
        public IEnumerable<AppointmentViewModel> UpcomingAppointments { get; set; }

        public IEnumerable<AppointmentViewModel> PastAppointments { get; set; }
    }
}
