namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public DateTime Time { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }
    }
}
