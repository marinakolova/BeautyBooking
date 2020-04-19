namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;

    public class AppointmentInputModel
    {
        public DateTime Time { get; set; }

        public int SalonId { get; set; }

        public int ServiceId { get; set; }
    }
}
