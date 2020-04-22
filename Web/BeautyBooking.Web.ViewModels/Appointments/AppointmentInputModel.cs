namespace BeautyBooking.Web.ViewModels.Appointments
{
    public class AppointmentInputModel
    {
        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
    }
}
