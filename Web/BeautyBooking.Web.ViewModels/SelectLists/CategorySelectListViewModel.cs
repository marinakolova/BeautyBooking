namespace BeautyBooking.Web.ViewModels.SelectLists
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CategorySelectListViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
