namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }
    }
}
