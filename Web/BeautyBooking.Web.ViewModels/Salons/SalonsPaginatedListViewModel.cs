namespace BeautyBooking.Web.ViewModels.Salons
{
    using BeautyBooking.Web.ViewModels.Common.Pagination;

    public class SalonsPaginatedListViewModel
    {
        public PaginatedList<SalonViewModel> Salons { get; set; }
    }
}
