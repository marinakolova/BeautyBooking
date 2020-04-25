namespace BeautyBooking.Services.Data.Appointments
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<T> GetByIdAsync<T>(string id);

        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<T>> GetAllBySalonAsync<T>(string salonId);

        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId);

        Task AddAsync(string userId, string salonId, int serviceId, DateTime dateTime);

        Task DeleteAsync(string id);

        Task ConfirmAsync(string id);

        Task DeclineAsync(string id);

        Task RateAppointmentAsync(string id);
    }
}
