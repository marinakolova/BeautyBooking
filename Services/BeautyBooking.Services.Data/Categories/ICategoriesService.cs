namespace BeautyBooking.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<IEnumerable<string>> GetAllNamesAsync();

        Task<T> GetByIdAsync<T>(int id);

        Task<int> GetIdByNameAsync(string name);

        Task AddAsync(string name, string description, IFormFile image);

        Task DeleteAsync(int id);
    }
}
