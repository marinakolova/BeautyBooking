namespace BeautyBooking.Web.ViewModels.Cities
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CityViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SalonsCount { get; set; }
    }
}
