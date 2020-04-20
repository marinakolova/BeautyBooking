namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<int> GetCountAsync();

        Task<IEnumerable<T>> GetAllByUserAsync<T>(string userId);
    }
}
