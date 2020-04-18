namespace BeautyBooking.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CitiesService : ICitiesService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;

        public CitiesService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            IQueryable<City> query =
                this.citiesRepository.All().OrderBy(x => x.Id);

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllCitiesNamesAsync()
        {
            ICollection<string> citiesNames =
                await this.citiesRepository.All()
                .OrderByDescending(x => x.Id)
                .Select(x => x.Name)
                .ToListAsync();

            return citiesNames;
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var city = await this.citiesRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return city;
        }

        public async Task<T> GetByNameAsync<T>(string name)
        {
            var city = await this.citiesRepository.All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .To<T>().FirstOrDefaultAsync();
            return city;
        }
    }
}
