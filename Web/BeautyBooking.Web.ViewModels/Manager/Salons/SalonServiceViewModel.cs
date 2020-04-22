namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonServiceViewModel : IMapFrom<SalonService>
    {
        public string SalonId { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public bool Available { get; set; }

        public double? Price { get; set; }
    }
}
