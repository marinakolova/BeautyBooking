namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Salons;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class SalonsServiceTests : BaseServiceTests
    {
        private ISalonsService Service => this.ServiceProvider.GetRequiredService<ISalonsService>();

        /*
        TODO: Task<IEnumerable<T>> GetAllAsync<T>();

        TODO: Task<IEnumerable<T>> GetAllWithSortingFilteringAndPagingAsync<T>(
            string searchString,
            int? sortId,
            int pageSize,
            int pageIndex);

        TODO: Task<T> GetByIdAsync<T>(string id);
         */

        [Fact]
        public async Task GetCountForPaginationAsyncShouldReturnCorrectCount()
        {
            await this.CreateSalonAsync(Guid.NewGuid().ToString());
            await this.CreateSalonAsync(Guid.NewGuid().ToString());
            await this.CreateSalonAsync(Guid.NewGuid().ToString());

            var actual = await this.Service.GetCountForPaginationAsync(" ", 0);
            Assert.Equal(0, actual);
        }

        [Fact]
        public async Task GetAllIdsByCategoryAsyncShouldReturnCorrectCount()
        {
            var salon1 = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = new NLipsum.Core.Sentence().ToString(),
                CategoryId = 5,
                CityId = 1,
                Address = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                Rating = 4,
                RatersCount = 1,
            };
            var salon2 = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = new NLipsum.Core.Sentence().ToString(),
                CategoryId = 5,
                CityId = 1,
                Address = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                Rating = 4,
                RatersCount = 1,
            };
            var salon3 = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = new NLipsum.Core.Sentence().ToString(),
                CategoryId = 5,
                CityId = 1,
                Address = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                Rating = 4,
                RatersCount = 1,
            };

            await this.DbContext.Salons.AddRangeAsync(salon1, salon2, salon3);
            await this.DbContext.SaveChangesAsync();

            var expected = this.DbContext.Salons.Where(x => x.CategoryId == 5).Count();
            var actual = await this.Service.GetAllIdsByCategoryAsync(5);
            var actualCount = 0;
            foreach (var result in actual)
            {
                actualCount++;
            }

            Assert.Equal(expected, actualCount);
        }

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            var newGuidId = Guid.NewGuid().ToString();
            await this.CreateSalonAsync(newGuidId);

            var name = new NLipsum.Core.Sentence().ToString();
            var categoryId = 1;
            var cityId = 1;
            var address = new NLipsum.Core.Sentence().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name, categoryId, cityId, address, imageUrl);

            var salonsCount = await this.DbContext.Salons.CountAsync();
            Assert.Equal(2, salonsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var newGuidId = Guid.NewGuid().ToString();

            var salon = await this.CreateSalonAsync(newGuidId);

            await this.Service.DeleteAsync(salon.Id);

            var salonsCount = this.DbContext.Salons.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedSalon = await this.DbContext.Salons.FirstOrDefaultAsync(x => x.Id == salon.Id);
            Assert.Equal(0, salonsCount);
            Assert.Null(deletedSalon);
        }

        [Fact]
        public async Task RateSalonAsyncShouldGiveCorrectRating()
        {
            var newGuidId = Guid.NewGuid().ToString();
            var salon = await this.CreateSalonAsync(newGuidId);

            var rateValue = 4;
            await this.Service.RateSalonAsync(newGuidId, rateValue);

            var expected = rateValue;
            var actual = salon.Rating;

            Assert.Equal(expected, actual);
        }

        private async Task<Salon> CreateSalonAsync(string newGuidId)
        {
            var salon = new Salon
            {
                Id = newGuidId,
                Name = new NLipsum.Core.Sentence().ToString(),
                CategoryId = 1,
                CityId = 1,
                Address = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                Rating = 4,
                RatersCount = 1,
            };

            await this.DbContext.Salons.AddAsync(salon);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<Salon>(salon).State = EntityState.Detached;
            return salon;
        }
    }
}
