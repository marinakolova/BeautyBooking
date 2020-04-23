namespace BeautyBooking.Web.ViewModels.Salons
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentOfSalonViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }
    }
}
