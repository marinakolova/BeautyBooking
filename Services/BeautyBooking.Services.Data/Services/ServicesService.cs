namespace BeautyBooking.Services.Data.Services
{
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;

    public class ServicesService : IServicesService
    {
        private readonly IDeletableEntityRepository<Service> servicesRepository;

        public ServicesService(IDeletableEntityRepository<Service> servicesRepository)
        {
            this.servicesRepository = servicesRepository;
        }
    }
}
