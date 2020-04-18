namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ServicesService : IServicesService
    {
        private readonly IDeletableEntityRepository<Service> servicesRepository;

        public ServicesService(IDeletableEntityRepository<Service> servicesRepository)
        {
            this.servicesRepository = servicesRepository;
        }

        public async Task<IEnumerable<int>> GetAllServicesInCategoryAsync(int categoryId)
        {
            ICollection<int> servicesIds =
                await this.servicesRepository.All()
                .Where(x => x.CategoryId == categoryId)
                .Select(x => x.Id)
                .ToListAsync();

            return servicesIds;
        }
    }
}
