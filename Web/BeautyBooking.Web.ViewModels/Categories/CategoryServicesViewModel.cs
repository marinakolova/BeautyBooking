namespace BeautyBooking.Web.ViewModels.Categories
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CategoryServicesViewModel : IMapFrom<Service>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
