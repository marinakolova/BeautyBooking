namespace BeautyBooking.Web.ViewModels.Appointments
{
    using System;

    public class AppointmentInputModel
    {
        public int SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public double? Price { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
    }
}
