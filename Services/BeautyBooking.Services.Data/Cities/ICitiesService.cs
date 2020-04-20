namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<string>> GetAllNamesAsync();

        Task<T> GetByIdAsync<T>(int id);

        Task<int> GetIdByNameAsync(string name);

        Task AddAsync(string name);

        Task DeleteAsync(int id);
    }
}
