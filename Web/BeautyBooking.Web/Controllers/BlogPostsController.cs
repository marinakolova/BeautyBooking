namespace BeautyBooking.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.BlogPosts;
    using BeautyBooking.Web.ViewModels.BlogPosts;
    using BeautyBooking.Web.ViewModels.Common.Pagination;
    using Microsoft.AspNetCore.Mvc;

    public class BlogPostsController : BaseController
    {
        private readonly IBlogPostsService blogPostsService;

        public BlogPostsController(IBlogPostsService blogPostsService)
        {
            this.blogPostsService = blogPostsService;
        }

        public async Task<IActionResult> Index(
            int? sortId,
            int? pageNumber) // blogPostId
        {
            if (sortId != null)
            {
                var blogPost = await this.blogPostsService
                    .GetByIdAsync<BlogPostViewModel>(sortId.Value);
                if (blogPost == null)
                {
                    return new StatusCodeResult(404);
                }
            }

            this.ViewData["CurrentSort"] = sortId;

            int pageSize = PageSizesConstants.BlogPosts;
            var pageIndex = pageNumber ?? 1;

            var blogPosts = await this.blogPostsService
                .GetAllWithPagingAsync<BlogPostViewModel>(sortId, pageSize, pageIndex);
            var blogPostsList = blogPosts.ToList();

            var count = await this.blogPostsService.GetCountForPaginationAsync();

            var viewModel = new BlogPostsPaginatedListViewModel
            {
                BlogPosts = new PaginatedList<BlogPostViewModel>(blogPostsList, count, pageIndex, pageSize),
            };

            return this.View(viewModel);
        }
    }
}
