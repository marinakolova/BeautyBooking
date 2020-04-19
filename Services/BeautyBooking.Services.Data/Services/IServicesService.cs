namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IServicesService
    {
        Task<IEnumerable<int>> GetAllServicesInCategoryAsync(int categoryId);

        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task DeleteServiceAsync(int id);
    }
}
