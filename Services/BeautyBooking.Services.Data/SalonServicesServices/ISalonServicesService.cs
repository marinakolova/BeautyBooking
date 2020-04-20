namespace BeautyBooking.Services.Data.SalonServicesServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonServicesService
    {
        Task AddSalonServicesAsync(IEnumerable<int> salonsIds, int serviceId);

        Task AddSalonServicesAsync(int salonId, IEnumerable<int> servicesIds);
    }
}
