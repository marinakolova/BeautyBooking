namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<int> GetCountAsync();

        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId);

        Task AddAsync(string userId, int salonId, int serviceId, string date, string time);

        Task DeleteAsync(int id);

        Task Confirm(int id);

        Task Decline(int id);
    }
}
