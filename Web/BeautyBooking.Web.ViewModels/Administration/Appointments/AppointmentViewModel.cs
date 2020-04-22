namespace BeautyBooking.Web.ViewModels.Administration.Appointments
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public DateTime Time { get; set; }

        public string UserEmail { get; set; }

        public string SalonName { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }
    }
}
