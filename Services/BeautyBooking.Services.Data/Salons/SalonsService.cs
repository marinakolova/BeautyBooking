namespace BeautyBooking.Services.Data.Salons
{
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;

    public class SalonsService : ISalonsService
    {
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public SalonsService(IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.salonsRepository = salonsRepository;
        }
    }
}
