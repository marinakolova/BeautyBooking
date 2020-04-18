namespace BeautyBooking.Web.ViewModels.Owner.SalonManager
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CityForSalonInputModel : IMapFrom<City>
    {
        public int Id { get; set; }
    }
}
