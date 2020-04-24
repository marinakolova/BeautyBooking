namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name);

        Task DeleteAsync(int id);
    }
}
