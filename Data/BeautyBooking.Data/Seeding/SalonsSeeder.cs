namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Salons.Any())
            {
                return;
            }

            var salons = new Salon[]
                {
                    // 1. Hairdressers and hair salons
                    new Salon
                    {
                        Name = "Salon De Style",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Laidlaw Close 28",
                        ImageUrl = GlobalConstants.Images.Hair1,
                    },
                    new Salon
                    {
                        Name = "Happy Hair Salon",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Francis Way 198",
                        ImageUrl = GlobalConstants.Images.Hair2,
                    },
                    new Salon
                    {
                        Name = "Angel Hair Salon",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Rosehill Crescent 93",
                        ImageUrl = GlobalConstants.Images.Hair3,
                    },

                    // 2. Hair removal salons
                    new Salon
                    {
                        Name = "Pretty Her Salon",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Pintail Close 5",
                        ImageUrl = GlobalConstants.Images.HairRemoval1,
                    },
                    new Salon
                    {
                        Name = "Charms Salon",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Ellesmere Gardens 143",
                        ImageUrl = GlobalConstants.Images.HairRemoval2,
                    },
                    new Salon
                    {
                        Name = "Little Sweets Salon",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Sykes Avenue 128",
                        ImageUrl = GlobalConstants.Images.HairRemoval3,
                    },

                    // 3. Massage Salons and Therapists
                    new Salon
                    {
                        Name = "Treat Yourself",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Sunnydale 38",
                        ImageUrl = GlobalConstants.Images.Massage1,
                    },
                    new Salon
                    {
                        Name = "Your Style Spa",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Swinton Road 158",
                        ImageUrl = GlobalConstants.Images.Massage2,
                    },
                    new Salon
                    {
                        Name = "Little Castle",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Penywern Road 43",
                        ImageUrl = GlobalConstants.Images.Massage3,
                    },

                    // 4. Nail salons and nail bars
                    new Salon
                    {
                        Name = "Cool Colors",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Greenview Drive 119",
                        ImageUrl = GlobalConstants.Images.Nails1,
                    },
                    new Salon
                    {
                        Name = "The Barbie Boutique",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Stratford Crescent 15",
                        ImageUrl = GlobalConstants.Images.Nails2,
                    },
                    new Salon
                    {
                        Name = "Salon Don",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Malet Close 28",
                        ImageUrl = GlobalConstants.Images.Nails3,
                    },

                    // 5. Face treatments
                    new Salon
                    {
                        Name = "Makeover Paradise",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Abbotsbury Way 81",
                        ImageUrl = GlobalConstants.Images.Face1,
                    },
                    new Salon
                    {
                        Name = "The Beauty Studio",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Trossachs Road 62",
                        ImageUrl = GlobalConstants.Images.Face2,
                    },
                    new Salon
                    {
                        Name = "Hot Chic",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Apsley Way 16",
                        ImageUrl = GlobalConstants.Images.Face3,
                    },

                    // 6. Body treatments
                    new Salon
                    {
                        Name = "Harmony",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Warmington Road 122",
                        ImageUrl = GlobalConstants.Images.Body1,
                    },
                    new Salon
                    {
                        Name = "Bubbles Of Love",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Ingoe Close 75",
                        ImageUrl = GlobalConstants.Images.Body2,
                    },
                    new Salon
                    {
                        Name = "Beautiful Bodies Salon",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "Pool View 42",
                        ImageUrl = GlobalConstants.Images.Body3,
                    },
                };

            await dbContext.AddRangeAsync(salons);
        }
    }
}
