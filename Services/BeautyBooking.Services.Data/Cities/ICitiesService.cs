namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<string>> GetAllCitiesNamesAsync();

        Task<T> GetByIdAsync<T>(int id);

        Task<T> GetByNameAsync<T>(string name);
    }
}
