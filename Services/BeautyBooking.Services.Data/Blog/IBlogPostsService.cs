namespace BeautyBooking.Services.Data.Blog
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface IBlogPostsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByTitle<T>(string title);

        T GetById<T>(int id);

        Task AddBlogPostAsync(string title, string content, string author, IFormFile image);

        Task DeleteBlogPostAsync(int id);
    }
}
