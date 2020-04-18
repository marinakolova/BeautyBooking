namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ISalonsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddSalonAsync(string name, string address, IFormFile image, int categoryId);

        Task DeleteSalonAsync(int id);
    }
}
