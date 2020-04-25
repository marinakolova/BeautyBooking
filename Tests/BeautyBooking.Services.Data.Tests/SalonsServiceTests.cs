namespace BeautyBooking.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data;
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Data.Repositories;
    using BeautyBooking.Services.Data.Salons;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Moq;

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

        TODO: Task<int> GetCountForPaginationAsync(string searchString, int? sortId);

        TODO: Task<IEnumerable<string>> GetAllIdsByCategoryAsync(int categoryId);

        TODO: Task<T> GetByIdAsync<T>(string id);
         */

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
