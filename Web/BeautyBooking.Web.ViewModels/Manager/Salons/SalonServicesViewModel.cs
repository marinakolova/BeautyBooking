namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonServicesViewModel : IMapFrom<SalonService>
    {
        public int SalonId { get; set; }

        public string SalonName { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }

        public bool Available { get; set; }

        public double? Price { get; set; }
    }
}
