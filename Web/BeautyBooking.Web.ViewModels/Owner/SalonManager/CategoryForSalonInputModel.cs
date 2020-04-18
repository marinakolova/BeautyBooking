namespace BeautyBooking.Web.ViewModels.Owner.SalonManager
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CategoryForSalonInputModel : IMapFrom<Category>
    {
        public int Id { get; set; }
    }
}
