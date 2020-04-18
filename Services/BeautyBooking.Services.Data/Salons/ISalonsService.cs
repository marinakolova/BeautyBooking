namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ISalonsService
    {
        Task RegisterSalonAsync(string name, string address, IFormFile image, int categoryId);

        IEnumerable<T> GetAll<T>(int? count = null);

        Task DeleteSalonAsync(int id);

        T GetById<T>(int id);
    }
}
