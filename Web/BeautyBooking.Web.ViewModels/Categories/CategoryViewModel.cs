namespace BeautyBooking.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<CategoryServicesViewModel> Services { get; set; }

        public int SalonsCount { get; set; }
    }
}
