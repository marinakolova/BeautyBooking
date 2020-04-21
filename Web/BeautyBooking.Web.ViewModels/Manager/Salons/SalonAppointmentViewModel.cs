namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonAppointmentViewModel : IMapFrom<Appointment>
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }
    }
}
