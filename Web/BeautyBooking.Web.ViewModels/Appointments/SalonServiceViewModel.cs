namespace BeautyBooking.Web.ViewModels.Appointments
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonServiceViewModel : IMapFrom<SalonService>
    {
        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public double? Price { get; set; }
    }
}
