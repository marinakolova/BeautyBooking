namespace BeautyBooking.Services.Data.Blog
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class BlogPostsService : IBlogPostsService
    {
        private readonly IDeletableEntityRepository<BlogPost> blogPostsRepository;

        public BlogPostsService(IDeletableEntityRepository<BlogPost> blogPostsRepository)
        {
            this.blogPostsRepository = blogPostsRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<BlogPost> query =
                this.blogPostsRepository.All().OrderBy(x => x.Title);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetByTitle<T>(string title)
        {
            var blogPost = this.blogPostsRepository.All()
                .Where(x => x.Title.Replace(" ", "-") == title.Replace(" ", "-"))
                .To<T>().FirstOrDefault();
            return blogPost;
        }

        public T GetById<T>(int id)
        {
            var blogPost = this.blogPostsRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return blogPost;
        }

        public async Task AddBlogPostAsync(string title, string content, string author, string imageUrl)
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

        public async Task DeleteBlogPostAsync(int id)
        {
            var blogPost = await this.blogPostsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.blogPostsRepository.Delete(blogPost);

            await this.blogPostsRepository.SaveChangesAsync();
        }
    }
}
