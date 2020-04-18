namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;

    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            // if (dbContext.Salons.Any())
            // {
            //     return;
            // }
            //
            // var salons = new Salon[]
            //     {
            //         new Salon
            //         {
            //         },
            //     };
            // 
            // await dbContext.AddRangeAsync(salons);
        }
    }
}
