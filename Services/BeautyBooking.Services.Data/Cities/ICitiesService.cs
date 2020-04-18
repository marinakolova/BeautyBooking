namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;

    public interface ICitiesService
    {
        IEnumerable<T> GetAll<T>();
    }
}
