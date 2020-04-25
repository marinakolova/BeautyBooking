namespace BeautyBooking.Services.Data.SalonServicesServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonServicesService
    {
        Task<T> GetByIdAsync<T>(string salonId, int serviceId);

        Task AddAsync(string salonId, IEnumerable<int> servicesIds);

        Task AddAsync(IEnumerable<string> salonsIds, int serviceId);

        Task ChangeAvailableStatusAsync(string salonId, int serviceId);
    }
}
