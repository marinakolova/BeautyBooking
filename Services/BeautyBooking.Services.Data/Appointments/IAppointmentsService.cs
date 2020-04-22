namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<IEnumerable<T>> GetAllUpcomingAsync<T>();

        Task<IEnumerable<T>> GetAllPastAsync<T>();

        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId);

        Task AddAsync(string userId, int salonId, int serviceId, string date, string time);

        Task DeleteAsync(int id);

        Task ConfirmAsync(int id);

        Task DeclineAsync(int id);
    }
}
