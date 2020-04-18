namespace BeautyBooking.Services.Data.SalonServicesServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;

    public class SalonServicesService : ISalonServicesService
    {
        private readonly IDeletableEntityRepository<SalonService> salonServicesRepository;

        public SalonServicesService(IDeletableEntityRepository<SalonService> salonServicesRepository)
        {
            this.salonServicesRepository = salonServicesRepository;
        }

        public async Task AddSalonServicesAsync(int salonId, IEnumerable<int> servicesIds)
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
    }
}
