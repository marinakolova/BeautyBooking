namespace BeautyBooking.Services.Data.SalonServicesServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonServicesService
    {
        Task<T> GetByIdAsync<T>(int salonId, int serviceId);

        Task AddAsync(int salonId, IEnumerable<int> servicesIds);

        Task AddAsync(IEnumerable<int> salonsIds, int serviceId);
    }
}
