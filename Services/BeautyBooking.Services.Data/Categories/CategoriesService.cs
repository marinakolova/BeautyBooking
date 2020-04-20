namespace BeautyBooking.Services.Data.Categories
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

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly ICloudinaryService cloudinaryService;

        public CategoriesService(
            IDeletableEntityRepository<Category> categoriesRepository,
            ICloudinaryService cloudinaryService)
        {
            this.categoriesRepository = categoriesRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Category> query =
                this.categoriesRepository.All().OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllNamesAsync()
        {
            ICollection<string> names =
                await this.categoriesRepository.All()
                .OrderBy(x => x.Id)
                .Select(x => x.Name)
                .ToListAsync();

            return names;
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var category = await this.categoriesRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return category;
        }

        public async Task<int> GetIdByNameAsync(string name)
        {
            var categoryId = await this.categoriesRepository.All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .Select(x => x.Id)
                .FirstOrDefaultAsync();
            return categoryId;
        }

        public async Task AddAsync(string name, string description, IFormFile image)
        {
            var imageUrl = await this.cloudinaryService.UploadPictureAsync(image, name);

            await this.categoriesRepository.AddAsync(new Category
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
            });

            await this.categoriesRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await this.categoriesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.categoriesRepository.Delete(category);

            await this.categoriesRepository.SaveChangesAsync();
        }
    }
}
