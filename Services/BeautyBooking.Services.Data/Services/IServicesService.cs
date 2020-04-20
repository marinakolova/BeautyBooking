namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IServicesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task<IEnumerable<int>> GetAllServicesInCategoryAsync(int categoryId);

        Task<int> AddServiceAsync(string name, int categoryId, string description);

        Task DeleteServiceAsync(int id);
    }
}
