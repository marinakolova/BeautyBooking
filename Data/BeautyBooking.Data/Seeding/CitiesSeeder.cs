namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;

    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var cities = new City[]
                {
                    new City // Id = 1
                    {
                        Name = "Sofia",
                    },
                    new City // Id = 2
                    {
                        Name = "Plovdiv",
                    },
                    new City // Id = 3
                    {
                        Name = "Varna",
                    },
                };

            await dbContext.AddRangeAsync(cities);
        }
    }
}
