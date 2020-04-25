namespace BeautyBooking.Services.Data.BlogPosts
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using BeautyBooking.Web.ViewModels.BlogPosts;
    using Microsoft.EntityFrameworkCore;

    public class BlogPostsService : IBlogPostsService
    {
        private readonly IDeletableEntityRepository<BlogPost> blogPostsRepository;

        public BlogPostsService(IDeletableEntityRepository<BlogPost> blogPostsRepository)
        {
            this.blogPostsRepository = blogPostsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<BlogPost> query =
                this.blogPostsRepository
                .All()
                .OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithPagingAsync<T>(
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<BlogPost> query =
                this.blogPostsRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn);

            if (sortId != null)
            {
                query = query
                    .Where(x => x.Id == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).To<T>().ToListAsync();
        }

        public async Task<int> GetCountForPaginationAsync()
        {
            return await this.blogPostsRepository
                .AllAsNoTracking()
                .CountAsync();

            // return await query.CountAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var blogPost =
                await this.blogPostsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return blogPost;
        }

        public async Task AddAsync(string title, string content, string author, string imageUrl)
        {
            await this.blogPostsRepository.AddAsync(new BlogPost
            {
                Title = title,
                Content = content,
                Author = author,
                ImageUrl = imageUrl,
            });
            await this.blogPostsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var blogPost =
                await this.blogPostsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.blogPostsRepository.Delete(blogPost);
            await this.blogPostsRepository.SaveChangesAsync();
        }
    }
}
