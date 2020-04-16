namespace BeautyBooking.Web.ViewModels.Blog
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexBlogViewModel> BlogPosts { get; set; }
    }
}
