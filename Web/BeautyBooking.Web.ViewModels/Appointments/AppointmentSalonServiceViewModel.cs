namespace BeautyBooking.Web.ViewModels.Appointments
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentSalonServiceViewModel : IMapFrom<SalonService>
    {
        public string SalonName { get; set; }

        public string SalonAddress { get; set; }

        public string ServiceName { get; set; }

        public double? Price { get; set; }
    }
}
