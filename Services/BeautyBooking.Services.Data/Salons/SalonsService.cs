namespace BeautyBooking.Services.Data.Salons
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

    public class SalonsService : ISalonsService
    {
        private readonly IDeletableEntityRepository<Salon> salonsRepository;
        private readonly ICloudinaryService cloudinaryService;

        public SalonsService(
            IDeletableEntityRepository<Salon> salonsRepository, 
            ICloudinaryService cloudinaryService)
        {
            this.salonsRepository = salonsRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Salon> query =
                this.salonsRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<int>> GetAllByCategoryAsync(int categoryId)
        {
            ICollection<int> salonsIds =
                await this.salonsRepository.All()
                .Where(x => x.CategoryId == categoryId)
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .ToListAsync();

            return salonsIds;
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var salon = await this.salonsRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return salon;
        }

        public async Task<int> AddAsync(string name, int categoryId, int cityId, string address, IFormFile image)
        {
            var imageUrl = await this.cloudinaryService.UploadPictureAsync(image, name);

            var salon = new Salon
            {
                Name = name,
                CategoryId = categoryId,
                CityId = cityId,
                Address = address,
                ImageUrl = imageUrl,
            };

            await this.salonsRepository.AddAsync(salon);
            await this.salonsRepository.SaveChangesAsync();

            return salon.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var salon = await this.salonsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.salonsRepository.Delete(salon);

            await this.salonsRepository.SaveChangesAsync();
        }
    }
}
