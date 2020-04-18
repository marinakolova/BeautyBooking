namespace BeautyBooking.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IServicesService
    {
        Task<IEnumerable<int>> GetAllServicesInCategoryAsync(int categoryId);
    }
}
