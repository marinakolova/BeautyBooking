namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ISalonsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task<int> AddSalonAsync(string name, int categoryId, int cityId, string address, IFormFile image);

        Task DeleteSalonAsync(int id);
    }
}
