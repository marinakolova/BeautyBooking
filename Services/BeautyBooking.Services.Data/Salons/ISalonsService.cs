namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<T>> GetAllByCategoryAsync<T>(int categoryId);

        Task<IEnumerable<string>> GetAllByCategoryAsync(int categoryId);

        Task<T> GetByIdAsync<T>(string id);

        Task<string> AddAsync(string name, int categoryId, int cityId, string address, string imageUrl);

        Task DeleteAsync(string id);

        Task RateSalon(string id, int rateValue);
    }
}
