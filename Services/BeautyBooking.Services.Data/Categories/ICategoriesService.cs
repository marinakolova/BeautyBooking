namespace BeautyBooking.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task<IEnumerable<string>> GetAllCategoriesNamesAsync();

        Task<int> GetIdByNameAsync(string name);

        Task AddCategoryAsync(string name, string description, IFormFile image);

        Task DeleteCategoryAsync(int id);
    }
}
