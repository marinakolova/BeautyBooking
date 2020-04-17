namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalonsService : ISalonsService
    {
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public SalonsService(IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.salonsRepository = salonsRepository;
        }

        public async Task RegisterSalonAsync(string name, string address, string imageUrl, string ownerId, int categoryId)
        {
            await this.salonsRepository.AddAsync(new Salon
            {
                Name = name,
                Address = address,
                ImageUrl = imageUrl,
                OwnerId = ownerId,
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

        public IEnumerable<T> GetByOwner<T>(string userId)
        {
            var salons = this.salonsRepository.All()
                .Where(x => x.OwnerId == userId)
                .To<T>().ToList();
            return salons;
        }
    }
}
