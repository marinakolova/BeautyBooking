namespace BeautyBooking.Services.Data.Appointments
{
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentsRepository;

        public AppointmentsService(IDeletableEntityRepository<Appointment> appointmentsRepository)
        {
            this.appointmentsRepository = appointmentsRepository;
        }
    }
}
