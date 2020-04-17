namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            // Add Salons
            // if (!dbContext.Salons.Any())
            // {
            //     var salons = new Salon[]
            //     {
            //         new Salon
            //         {
            //         },
            //     };
            //
            //     await dbContext.AddRangeAsync(salons);
            // }
        }
    }
}
