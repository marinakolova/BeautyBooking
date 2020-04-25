namespace BeautyBooking.Services.Data.BlogPosts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBlogPostsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<IEnumerable<T>> GetAllWithPagingAsync<T>(
            int? sortId,
            int pageSize,
            int pageIndex);

        Task<int> GetCountForPaginationAsync();

        Task<T> GetByIdAsync<T>(int id);

        Task AddAsync(string title, string content, string author, string imageUrl);

        Task DeleteAsync(int id);
    }
}
