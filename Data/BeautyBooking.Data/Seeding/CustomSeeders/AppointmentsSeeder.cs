namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Appointments.Any())
            {
                return;
            }

            var appointments = new List<Appointment>();

            // Get User Id
            var userId = dbContext.Users.Where(x => x.Email == GlobalConstants.AccountsSeeding.UserEmail).FirstOrDefault().Id;

            // Get 3 Salons Ids
            var salonsIds = await dbContext.Salons.Where(x => x.CityId == 1).Select(x => x.Id).Take(3).ToListAsync();

            foreach (var salonId in salonsIds)
            {
                // Get a Service from each Salon
                var serviceId = dbContext.SalonServices.Where(x => x.SalonId == salonId).FirstOrDefault().ServiceId;

                // Add Appointment with date 5 days from now
                appointments.Add(new Appointment
                {
                    Time = DateTime.UtcNow.AddDays(5),
                    UserId = userId,
                    SalonId = salonId,
                    ServiceId = serviceId,
                });
            }

            await dbContext.AddRangeAsync(appointments);
        }
    }
}
