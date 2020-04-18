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

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository, ICloudinaryService cloudinaryService)
        {
            this.categoriesRepository = categoriesRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query =
                this.categoriesRepository.All().OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            var category = this.categoriesRepository.All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .To<T>().FirstOrDefault();
            return category;
        }

        public T GetById<T>(int id)
        {
            var category = this.categoriesRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return category;
        }

        public async Task AddCategoryAsync(string name, string description, IFormFile image)
        {
            var imageUrl = await this.cloudinaryService.UploadPictureAsync(image, "categorytest");

            await this.categoriesRepository.AddAsync(new Category
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
            });

            await this.categoriesRepository.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
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
