namespace BeautyBooking.Web.ViewModels.BlogPosts
{
    using BeautyBooking.Web.ViewModels.Common.Pagination;

    public class BlogPostsPaginatedListViewModel
    {
        public PaginatedList<BlogPostViewModel> BlogPosts { get; set; }
    }
}
