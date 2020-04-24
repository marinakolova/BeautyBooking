namespace BeautyBooking.Web.ViewModels.SalonServices
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonServiceSimpleViewModel : IMapFrom<SalonService>
    {
        public string SalonId { get; set; }

        public int ServiceId { get; set; }

        public bool Available { get; set; }
    }
}
