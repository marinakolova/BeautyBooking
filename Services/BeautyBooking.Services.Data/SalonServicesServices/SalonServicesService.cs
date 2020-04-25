namespace BeautyBooking.Services.Data.SalonServicesServices
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalonServicesService : ISalonServicesService
    {
        private readonly IDeletableEntityRepository<SalonService> salonServicesRepository;

        public SalonServicesService(IDeletableEntityRepository<SalonService> salonServicesRepository)
        {
            this.salonServicesRepository = salonServicesRepository;
        }

        public async Task<T> GetByIdAsync<T>(string salonId, int serviceId)
        {
            var salonService =
                await this.salonServicesRepository
                .All()
                .Where(x => x.SalonId == salonId && x.ServiceId == serviceId)
                .To<T>().FirstOrDefaultAsync();
            return salonService;
        }

        public async Task AddAsync(string salonId, IEnumerable<int> servicesIds)
        {
            foreach (var serviceId in servicesIds)
            {
                await this.salonServicesRepository.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await this.salonServicesRepository.SaveChangesAsync();
        }

        public async Task AddAsync(IEnumerable<string> salonsIds, int serviceId)
        {
            foreach (var salonId in salonsIds)
            {
                await this.salonServicesRepository.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await this.salonServicesRepository.SaveChangesAsync();
        }

        public async Task ChangeAvailableStatusAsync(string salonId, int serviceId)
        {
            var salonService =
                await this.salonServicesRepository
                .All()
                .Where(x => x.SalonId == salonId
                            && x.ServiceId == serviceId)
                .FirstOrDefaultAsync();

            salonService.Available = !salonService.Available;

            await this.salonServicesRepository.SaveChangesAsync();
        }
    }
}
