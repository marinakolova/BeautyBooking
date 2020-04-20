namespace BeautyBooking.Services.Data.Users
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            IQueryable<ApplicationUser> query =
                this.usersRepository.All().OrderBy(x => x.CreatedOn);

            return await query.To<T>().ToListAsync();
        }
    }
}
