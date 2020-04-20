namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        int GetAllAppointmentsCount();

        Task<IEnumerable<T>> GetByUserAsync<T>(string userId);
    }
}
