namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Linq;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class CitiesService : ICitiesService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;

        public CitiesService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            IQueryable<City> query =
                this.citiesRepository.All().OrderBy(x => x.Id);

            return query.To<T>().ToList();
        }
    }
}
