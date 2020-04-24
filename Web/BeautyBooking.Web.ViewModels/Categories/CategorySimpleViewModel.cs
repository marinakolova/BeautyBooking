namespace BeautyBooking.Web.ViewModels.Categories
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CategorySimpleViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SalonsCount { get; set; }
    }
}
