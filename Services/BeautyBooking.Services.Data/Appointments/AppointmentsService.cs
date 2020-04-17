namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Linq;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentsRepository;

        public AppointmentsService(IDeletableEntityRepository<Appointment> appointmentsRepository)
        {
            this.appointmentsRepository = appointmentsRepository;
        }

        public IEnumerable<T> GetByUser<T>(string userId)
        {
            var appointments = this.appointmentsRepository.All()
                .Where(x => x.ClientId == userId)
                .To<T>().ToList();
            return appointments;
        }
    }
}
