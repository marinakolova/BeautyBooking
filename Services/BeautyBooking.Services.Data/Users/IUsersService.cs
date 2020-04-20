namespace BeautyBooking.Services.Data.Users
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUsersService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();
    }
}
