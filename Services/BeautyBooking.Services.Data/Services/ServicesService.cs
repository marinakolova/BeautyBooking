namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class ServicesService : IServicesService
    {
        private readonly IDeletableEntityRepository<Service> servicesRepository;

        public ServicesService(IDeletableEntityRepository<Service> servicesRepository)
        {
            this.servicesRepository = servicesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var services =
                await this.servicesRepository
                .All()
                .OrderBy(x => x.CategoryId)
                .ThenBy(x => x.Id)
                .To<T>().ToListAsync();
            return services;
        }

        public async Task<IEnumerable<int>> GetAllIdsByCategoryAsync(int categoryId)
        {
            ICollection<int> servicesIds =
                await this.servicesRepository
                .All()
                .Where(x => x.CategoryId == categoryId)
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .ToListAsync();
            return servicesIds;
        }

        public async Task<int> AddAsync(string name, int categoryId, string description)
        {
            var service = new Service
            {
                Name = name,
                CategoryId = categoryId,
                Description = description,
            };
            await this.servicesRepository.AddAsync(service);
            await this.servicesRepository.SaveChangesAsync();
            return service.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var service =
                await this.servicesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.servicesRepository.Delete(service);
            await this.servicesRepository.SaveChangesAsync();
        }
    }
}
