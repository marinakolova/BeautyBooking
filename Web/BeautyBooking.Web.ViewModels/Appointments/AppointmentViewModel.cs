namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
