namespace BeautyBooking.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        T GetById<T>(int id);

        Task AddCategoryAsync(string name, string description, IFormFile image);

        Task DeleteCategoryAsync(int id);
    }
}
