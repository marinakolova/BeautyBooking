namespace BeautyBooking.Services.Data.Tests.UseMocking
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Data.Services;
    using Moq;
    using Xunit;

    public class ServicesServiceTests
    {
        /*
        TODO: Task<IEnumerable<T>> GetAllAsync<T>();
         */

        /*
       [Fact]
       public async Task GetAllAsyncShouldReturnCorrectNumber()
       {
           var repository = new Mock<IDeletableEntityRepository<Service>>();
           repository.Setup(r => r.All()).Returns(new List<Service>
                                                       {
                                                           new Service(),
                                                           new Service(),
                                                           new Service(),
                                                       }.AsQueryable());
           var service = new ServicesService(repository.Object);

           var result = await service.GetAllAsync<Service>();
           var resultCount = 0;
           foreach (var item in result)
           {
               resultCount++;
           }

           Assert.Equal(3, resultCount);
           repository.Verify(x => x.All(), Times.Once);
        }

            * Message:
   System.NullReferenceException : Object reference not set to an instance of an object.
 Stack Trace:
   QueryableMappingExtensions.To[TDestination](IQueryable source, Expression`1[] membersToExpand) line 20
   ServicesService.GetAllAsync[T]() line 23
   ServicesServiceTests.GetAllAsyncShouldReturnCorrectNumber() line 37
   --- End of stack trace from previous location where exception was thrown ---
*/
    }
}
