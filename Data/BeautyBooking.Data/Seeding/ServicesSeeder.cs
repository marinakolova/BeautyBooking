namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public class ServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            // Add Services
            // if (!dbContext.Services.Any())
            // {
            //     var services = new Service[]
            //     {
            //         new Service
            //         {
            //             Name = "",
            //             Description = "",
            //         },
            //     };
            // }
        }
    }
}
