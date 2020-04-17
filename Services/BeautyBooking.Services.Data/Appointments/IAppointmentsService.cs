namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;

    public interface IAppointmentsService
    {
        IEnumerable<T> GetByUser<T>(string userId);
    }
}
