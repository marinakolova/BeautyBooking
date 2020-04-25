namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.BlogPosts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class BlogPostsServiceTests : BaseServiceTests
    {
        private IBlogPostsService Service => this.ServiceProvider.GetRequiredService<IBlogPostsService>();

        /*
        TODO: Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        TODO: Task<IEnumerable<T>> GetAllWithPagingAsync<T>(
            int? sortId,
            int pageSize,
            int pageIndex);

        TODO: Task<T> GetByIdAsync<T>(int id);
         */

        [Fact]
        public async Task GetCountForPaginationAsyncShouldReturnCorrectCount()
        {
            await this.CreateBlogPostAsync();
            await this.CreateBlogPostAsync();
            await this.CreateBlogPostAsync();

            var expected = this.DbContext.BlogPosts.Where(x => !x.IsDeleted).ToArray().Count();
            var actual = await this.Service.GetCountForPaginationAsync();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateBlogPostAsync();

            var title = new NLipsum.Core.Sentence().ToString();
            var content = new NLipsum.Core.Paragraph().ToString();
            var author = new NLipsum.Core.Word().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(title, content, author, imageUrl);

            var blogPostsCount = await this.DbContext.BlogPosts.CountAsync();
            Assert.Equal(2, blogPostsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var blogPost = await this.CreateBlogPostAsync();

            await this.Service.DeleteAsync(blogPost.Id);

            var blogPostsCount = this.DbContext.BlogPosts.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedBlogPost = await this.DbContext.BlogPosts.FirstOrDefaultAsync(x => x.Id == blogPost.Id);
            Assert.Equal(0, blogPostsCount);
            Assert.Null(deletedBlogPost);
        }

        private async Task<BlogPost> CreateBlogPostAsync()
        {
            var blogPost = new BlogPost
            {
                Title = "Test Title",
                Content = new NLipsum.Core.Paragraph().ToString(),
                Author = new NLipsum.Core.Word().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.BlogPosts.AddAsync(blogPost);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<BlogPost>(blogPost).State = EntityState.Detached;
            return blogPost;
        }
    }
}
