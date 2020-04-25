namespace BeautyBooking.Services.Data.Salons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalonsService : ISalonsService
    {
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public SalonsService(IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.salonsRepository = salonsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var salons =
                await this.salonsRepository
                .All()
                .OrderBy(x => x.Name)
                .To<T>().ToListAsync();
            return salons;
        }

        public async Task<IEnumerable<T>> GetAllWithSortingFilteringAndPagingAsync<T>(
            string searchString,
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<Salon> query =
                this.salonsRepository
                .AllAsNoTracking()
                .OrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query
                    .Where(x => x.Name.ToLower()
                                .Contains(searchString.ToLower()));
            }

            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .To<T>().ToListAsync();
        }

        public async Task<int> GetCountForPaginationAsync(string searchString, int? sortId)
        {
            IQueryable<Salon> query =
                this.salonsRepository
                .AllAsNoTracking()
                .OrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query
                    .Where(x => x.Name.ToLower()
                                .Contains(searchString.ToLower()));
            }

            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query.CountAsync();
        }

        public async Task<IEnumerable<string>> GetAllIdsByCategoryAsync(int categoryId)
        {
            var salonsIds =
                await this.salonsRepository
                .All()
                .Where(x => x.CategoryId == categoryId)
                .Select(x => x.Id)
                .ToListAsync();
            return salonsIds;
        }

        public async Task<T> GetByIdAsync<T>(string id)
        {
            var salon =
                await this.salonsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return salon;
        }

        public async Task<string> AddAsync(string name, int categoryId, int cityId, string address, string imageUrl)
        {
            var salon = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                CategoryId = categoryId,
                CityId = cityId,
                Address = address,
                ImageUrl = imageUrl,
                Rating = 0,
                RatersCount = 0,
            };

            await this.salonsRepository.AddAsync(salon);
            await this.salonsRepository.SaveChangesAsync();
            return salon.Id;
        }

        public async Task DeleteAsync(string id)
        {
            var salon =
                await this.salonsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.salonsRepository.Delete(salon);
            await this.salonsRepository.SaveChangesAsync();
        }

        public async Task RateSalonAsync(string id, int rateValue)
        {
            var salon =
                await this.salonsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var oldRating = salon.Rating;
            var oldRatersCount = salon.RatersCount;

            var newRatersCount = oldRatersCount + 1;
            var newRating = (oldRating + rateValue) / newRatersCount;

            salon.Rating = newRating;
            salon.RatersCount = newRatersCount;

            await this.salonsRepository.SaveChangesAsync();
        }
    }
}
