namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Cities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class CitiesServiceTests : BaseServiceTests
    {
        private ICitiesService Service => this.ServiceProvider.GetRequiredService<ICitiesService>();

        /*
        TODO: Task<IEnumerable<T>> GetAllAsync<T>();
         */

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateCityAsync();

            var name = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name);

            var citiesCount = await this.DbContext.Cities.CountAsync();
            Assert.Equal(2, citiesCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var city = await this.CreateCityAsync();

            await this.Service.DeleteAsync(city.Id);

            var citysCount = this.DbContext.Cities.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedCity = await this.DbContext.Cities.FirstOrDefaultAsync(x => x.Id == city.Id);
            Assert.Equal(0, citysCount);
            Assert.Null(deletedCity);
        }

        private async Task<City> CreateCityAsync()
        {
            var city = new City
            {
                Name = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.Cities.AddAsync(city);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<City>(city).State = EntityState.Detached;
            return city;
        }
    }
}
