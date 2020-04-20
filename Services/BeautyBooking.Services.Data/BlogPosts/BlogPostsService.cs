namespace BeautyBooking.Services.Data.BlogPosts
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Cloudinary;
    using BeautyBooking.Services.Mapping;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;

    public class BlogPostsService : IBlogPostsService
    {
        private readonly IDeletableEntityRepository<BlogPost> blogPostsRepository;
        private readonly ICloudinaryService cloudinaryService;

        public BlogPostsService(
            IDeletableEntityRepository<BlogPost> blogPostsRepository,
            ICloudinaryService cloudinaryService)
        {
            this.blogPostsRepository = blogPostsRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<int> GetCountAsync()
        {
            return await this.blogPostsRepository.All().CountAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<BlogPost> query =
                this.blogPostsRepository.All().OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var blogPost = await this.blogPostsRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return blogPost;
        }

        public async Task AddAsync(string title, string content, string author, IFormFile image)
        {
            var imageUrl = await this.cloudinaryService.UploadPictureAsync(image, title);

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
            var blogPost = await this.blogPostsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.blogPostsRepository.Delete(blogPost);

            await this.blogPostsRepository.SaveChangesAsync();
        }
    }
}
