namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonsService
    {
        Task RegisterSalonAsync(string name, string address, string imageUrl, string ownerId);

        IEnumerable<T> GetAll<T>(int? count = null);

        Task DeleteSalonAsync(int id);
    }
}
