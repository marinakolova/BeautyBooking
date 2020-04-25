namespace BeautyBooking.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data;
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Data.Repositories;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Moq;

    using Xunit;

    public class SalonServicesServiceTests : BaseServiceTests
    {
        private ISalonServicesService Service => this.ServiceProvider.GetRequiredService<ISalonServicesService>();

        /*
        TODO: Task<T> GetByIdAsync<T>(string salonId, int serviceId);

        TODO: Task AddAsync(string salonId, IEnumerable<int> servicesIds);

        TODO: Task AddAsync(IEnumerable<string> salonsIds, int serviceId);

        TODO: Task ChangeAvailableStatus(string salonId, int serviceId);
         */

        /*
        [Fact]
        public void ChangeAvailableStatusShouldChangeStatusCorrectly()
        {
        }

        [Fact]
        public async Task ChangeAvailableStatusShouldChangeStatusCorrectlyUsingDbContext()
        {
        }
        */
    }
}
