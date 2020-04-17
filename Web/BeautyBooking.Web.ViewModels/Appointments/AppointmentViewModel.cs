namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public DateTime Time { get; set; }

        public virtual Salon Salon { get; set; }

        public virtual Service Service { get; set; }
    }
}
