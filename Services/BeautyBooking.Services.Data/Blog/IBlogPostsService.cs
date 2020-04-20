namespace BeautyBooking.Services.Data.Blog
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface IBlogPostsService
    {
        Task<int> GetCountAsync();

        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddAsync(string title, string content, string author, IFormFile image);

        Task DeleteAsync(int id);
    }
}
