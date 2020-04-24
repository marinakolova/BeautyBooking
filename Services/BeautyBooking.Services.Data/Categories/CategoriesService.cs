namespace BeautyBooking.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var categories = await this.categoriesRepository.All()
                .OrderBy(x => x.Id)
                .To<T>().ToListAsync();
            return categories;
        }

        public async Task AddAsync(string name, string description, string imageUrl)
        {
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
