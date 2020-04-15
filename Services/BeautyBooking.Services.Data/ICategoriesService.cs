namespace BeautyBooking.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>();

        T GetByName<T>(string name);
    }
}
