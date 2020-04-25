namespace BeautyBooking.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data;
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Data.Repositories;
    using BeautyBooking.Services.Data.Services;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Moq;

    using Xunit;

    public class ServicesServiceTests : BaseServiceTests
    {
        private IServicesService Service => this.ServiceProvider.GetRequiredService<IServicesService>();

        /*
        TODO: Task<IEnumerable<T>> GetAllAsync<T>();

        TODO: Task<IEnumerable<int>> GetAllIdsByCategoryAsync(int categoryId);
         */

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
