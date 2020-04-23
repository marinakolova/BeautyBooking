namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<T> GetByIdAsync<T>(string id);

        Task<IEnumerable<T>> GetAllUpcomingAsync<T>();

        Task<IEnumerable<T>> GetAllPastAsync<T>();

        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId);

        Task AddAsync(string userId, string salonId, int serviceId, string date, string time);

        Task DeleteAsync(string id);

        Task ConfirmAsync(string id);

        Task DeclineAsync(string id);

        Task RateAppointment(string id, double rateValue);
    }
}
