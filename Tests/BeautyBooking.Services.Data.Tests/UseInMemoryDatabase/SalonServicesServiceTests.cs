namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class SalonServicesServiceTests : BaseServiceTests
    {
        private ISalonServicesService Service => this.ServiceProvider.GetRequiredService<ISalonServicesService>();

        /*
        TODO: Task<T> GetByIdAsync<T>(string salonId, int serviceId);
         */

        [Fact]
        public async Task AddAsyncShouldWorkCorrectlyWithOneSalonAndManyServices()
        {
            var salon = await this.CreateSalonAsync();
            var service1 = await this.CreateServiceAsync();
            var service2 = await this.CreateServiceAsync();
            var service3 = await this.CreateServiceAsync();

            var salonId = salon.Id;
            var servicesIds = new List<int> { service1.Id, service2.Id, service3.Id };

            await this.Service.AddAsync(salonId, servicesIds);

            var expected = 3;
            var actual = await this.DbContext.SalonServices.CountAsync();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task AddAsyncShouldWorkCorrectlyWithManySalonsAndOneService()
        {
            var salon1 = await this.CreateSalonAsync();
            var salon2 = await this.CreateSalonAsync();
            var salon3 = await this.CreateSalonAsync();
            var service = await this.CreateServiceAsync();

            var salonsIds = new List<string> { salon1.Id, salon2.Id, salon3.Id };
            var serviceId = service.Id;

            await this.Service.AddAsync(salonsIds, serviceId);

            var expected = 3;
            var actual = await this.DbContext.SalonServices.CountAsync();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task ChangeAvailableStatusAsyncShouldChangeStatusCorrectly()
        {
            var salon = await this.CreateSalonAsync();
            var service = await this.CreateServiceAsync();
            var salonService = await this.CreateSalonServiceAsync(salon.Id, service.Id);

            await this.Service.ChangeAvailableStatusAsync(salon.Id, service.Id);

            Assert.True(salonService.Available);
        }

        private async Task<Salon> CreateSalonAsync()
        {
            // Add Salon
            var salon = new Salon
            {
                Id = Guid.NewGuid().ToString(),
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

        private async Task<Service> CreateServiceAsync()
        {
            // Add Service
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

        private async Task<SalonService> CreateSalonServiceAsync(string salonId, int serviceId)
        {
            // Add SalonService
            var salonService = new SalonService
            {
                SalonId = salonId,
                ServiceId = serviceId,
                Available = true,
            };

            await this.DbContext.SalonServices.AddAsync(salonService);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<SalonService>(salonService).State = EntityState.Detached;

            return salonService;
        }
    }
}
