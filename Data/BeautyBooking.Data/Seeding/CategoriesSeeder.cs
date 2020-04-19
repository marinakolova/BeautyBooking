namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
                {
                    new Category // Id = 1
                    {
                        Name = "Hair Salons",
                        Description = "Hair salons come in a variety of shapes and sizes. Whether you prefer to splurge on regular hair appointments or like to chop and change to suit your location and your budget, one thing is for certain - we all need a good trim every so often and a hair salon is the place to do it.",
                        ImageUrl = GlobalConstants.Images.Hair,
                    },
                    new Category // Id = 2
                    {
                        Name = "Hair Removal Salons",
                        Description = "Do you know your Brazilian from your Hollywood wax? Or the best way to rid your body of unwanted hair for good? Whether you're looking for long-term results or are content with your monthly wax sessions, a hair removal salon will cater to all your body hair needs under one roof.",
                        ImageUrl = GlobalConstants.Images.HairRemoval,
                    },
                    new Category // Id = 3
                    {
                        Name = "Massage and Spa Salons",
                        Description = "Tense, tight, muscles call for a massage. In the right hands your aches and pains can be massaged away within minutes. If you can’t seem to kick sore shoulders and aching joints, you need to get yourself to a massage salon, asap.",
                        ImageUrl = GlobalConstants.Images.Massage,
                    },
                    new Category // Id = 4
                    {
                        Name = "Nail Salons",
                        Description = "Go in feeling drab and un-groomed and come out looking like a million dollars. Yes, whether it's a quick shape and tidy, a full on set of gel nails or a bold, acrylic mani, nail salons have the power to transform your nails, and lift your mood!",
                        ImageUrl = GlobalConstants.Images.Nails,
                    },
                    new Category // Id = 5
                    {
                        Name = "Face Treatments",
                        Description = "If you're searching for the perfect facial, many beauty salons offer a range of treatments that cater to your complexion. Filled with expertly trained staff to get to the bottom of any skin issue, booking in for a facial is an important first step to getting your skin back on track.",
                        ImageUrl = GlobalConstants.Images.Face,
                    },
                    new Category // Id = 6
                    {
                        Name = "Body Treatments",
                        Description = "From tanning to exfoliation treatments, mud wraps to massages, if you're looking to treat your body to some serious pampering, booking into a beauty salon is the first step in your journey to utter relaxation.",
                        ImageUrl = GlobalConstants.Images.Body,
                    },
                };

            // Need them in particular order
            foreach (var category in categories)
            {
                await dbContext.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
