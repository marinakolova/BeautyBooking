namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonAppointmentsViewModel : IMapFrom<Appointment>
    {
        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string ServiceName { get; set; }
    }
}
