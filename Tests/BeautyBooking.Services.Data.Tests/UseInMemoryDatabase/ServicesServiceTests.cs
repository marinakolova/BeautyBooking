namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Services;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class ServicesServiceTests : BaseServiceTests
    {
        private IServicesService Service => this.ServiceProvider.GetRequiredService<IServicesService>();

        [Fact]
        public async Task GetAllIdsByCategoryAsyncShouldReturnCorrectCount()
        {
            var service1 = new Service
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                CategoryId = 10,
            };
            var service2 = new Service
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                CategoryId = 10,
            };
            var service3 = new Service
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                CategoryId = 10,
            };

            await this.DbContext.Services.AddRangeAsync(service1, service2, service3);
            await this.DbContext.SaveChangesAsync();

            var expected = this.DbContext.Services.Where(x => x.CategoryId == 10).Count();
            var actual = await this.Service.GetAllIdsByCategoryAsync(10);
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
            await this.CreateServiceAsync();

            var name = new NLipsum.Core.Sentence().ToString();
            var categoryId = 1;
            var description = new NLipsum.Core.Paragraph().ToString();

            await this.Service.AddAsync(name, categoryId, description);

            var servicesCount = await this.DbContext.Services.CountAsync();
            Assert.Equal(2, servicesCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var service = await this.CreateServiceAsync();

            await this.Service.DeleteAsync(service.Id);

            var servicesCount = this.DbContext.Services.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedService = await this.DbContext.Services.FirstOrDefaultAsync(x => x.Id == service.Id);
            Assert.Equal(0, servicesCount);
            Assert.Null(deletedService);
        }

        private async Task<Service> CreateServiceAsync()
        {
            var service = new Service
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                CategoryId = 1,
            };

            await this.DbContext.Services.AddAsync(service);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<Service>(service).State = EntityState.Detached;
            return service;
        }
    }
}
