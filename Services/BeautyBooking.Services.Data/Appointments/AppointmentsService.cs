namespace BeautyBooking.Services.Data.Appointments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.DateTimeParser;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentsRepository;
        private readonly IDateTimeParserService dateTimeParserService;

        public AppointmentsService(
            IDeletableEntityRepository<Appointment> appointmentsRepository,
            IDateTimeParserService dateTimeParserService)
        {
            this.appointmentsRepository = appointmentsRepository;
            this.dateTimeParserService = dateTimeParserService;
        }

        public async Task<IEnumerable<T>> GetAllUpcomingAsync<T>()
        {
            var appointments = await this.appointmentsRepository.All()
                .Where(x => x.DateTime > DateTime.UtcNow)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetAllPastAsync<T>()
        {
            var appointments = await this.appointmentsRepository.All()
                .Where(x => x.DateTime < DateTime.UtcNow && x.Confirmed == true)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId)
        {
            var appointments = await this.appointmentsRepository.All()
                .Where(x => x.UserId == userId && x.DateTime > DateTime.UtcNow)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId)
        {
            var appointments = await this.appointmentsRepository.All()
                .Where(x => x.UserId == userId && x.DateTime < DateTime.UtcNow && x.Confirmed == true)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task AddAsync(string userId, string salonId, int serviceId, string date, string time)
        {
            var dateTime = this.dateTimeParserService.ConvertStrings(date, time);

            await this.appointmentsRepository.AddAsync(new Appointment
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = dateTime,
                UserId = userId,
                SalonId = salonId,
                ServiceId = serviceId,
            });

            await this.appointmentsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var appointment = await this.appointmentsRepository.All()
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            appointment.IsDeleted = true;
            await this.appointmentsRepository.SaveChangesAsync();
        }

        public async Task ConfirmAsync(string id)
        {
            var appointment = await this.appointmentsRepository.All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = true;
            await this.appointmentsRepository.SaveChangesAsync();
        }

        public async Task DeclineAsync(string id)
        {
            var appointment = await this.appointmentsRepository.All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = false;
            await this.appointmentsRepository.SaveChangesAsync();
        }
    }
}
