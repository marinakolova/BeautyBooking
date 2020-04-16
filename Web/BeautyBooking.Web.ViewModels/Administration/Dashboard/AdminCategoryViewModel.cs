namespace BeautyBooking.Web.ViewModels.Administration.Dashboard
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AdminCategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int SalonsCount { get; set; }
    }
}
