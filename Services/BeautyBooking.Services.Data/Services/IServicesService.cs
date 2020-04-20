namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IServicesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<IEnumerable<int>> GetAllByCategoryAsync(int categoryId);

        Task<T> GetByIdAsync<T>(int id);

        Task<int> AddAsync(string name, int categoryId, string description);

        Task DeleteAsync(int id);
    }
}
