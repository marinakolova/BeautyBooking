namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;

    public class SalonServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.SalonServices.Any())
            {
                return;
            }

            var salonServices = new List<SalonService>();

            // For each Salon add all Services from its Category
            foreach (var salon in dbContext.Salons)
            {
                var salonId = salon.Id;
                var categoryId = salon.CategoryId;

                foreach (var service in dbContext.Services.Where(x => x.CategoryId == categoryId))
                {
                    var serviceId = service.Id;

                    salonServices.Add(new SalonService
                    {
                        SalonId = salonId,
                        ServiceId = serviceId,
                        Available = true,
                    });
                }
            }

            await dbContext.AddRangeAsync(salonServices);
        }
    }
}
