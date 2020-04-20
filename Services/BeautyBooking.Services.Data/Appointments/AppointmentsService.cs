namespace BeautyBooking.Services.Data.Appointments
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentsRepository;

        public AppointmentsService(IDeletableEntityRepository<Appointment> appointmentsRepository)
        {
            this.appointmentsRepository = appointmentsRepository;
        }

        public async Task<int> GetCountAsync()
        {
            return await this.appointmentsRepository.All().CountAsync();
        }

        public async Task<IEnumerable<T>> GetAllByUserAsync<T>(string userId)
        {
            var appointments = await this.appointmentsRepository.All()
                .Where(x => x.UserId == userId)
                .OrderBy(x => x.Time)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task AddAsync(string userId, int salonId, int serviceId)
        {
            await this.appointmentsRepository.AddAsync(new Appointment
            {
                UserId = userId,
                SalonId = salonId,
                ServiceId = serviceId,
            });

            await this.appointmentsRepository.SaveChangesAsync();
        }
    }
}
