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

        public SalonsService(IDeletableEntityRepository<Salon> salonsRepository, ICloudinaryService cloudinaryService)
        {
            this.salonsRepository = salonsRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task RegisterSalonAsync(string name, string address, IFormFile image, int categoryId)
        {
            var imageUrl = await this.cloudinaryService.UploadPictureAsync(image, name);

            await this.salonsRepository.AddAsync(new Salon
            {
                Name = name,
                Address = address,
                ImageUrl = imageUrl,
                CategoryId = categoryId,
            });

            await this.salonsRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Salon> query =
                this.salonsRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public async Task DeleteSalonAsync(int id)
        {
            var salon = await this.salonsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.salonsRepository.Delete(salon);

            await this.salonsRepository.SaveChangesAsync();
        }

        public T GetById<T>(int id)
        {
            var salon = this.salonsRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return salon;
        }
    }
}
