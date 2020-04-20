namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Users;
    using BeautyBooking.Web.ViewModels.Administration.Users;
    using Microsoft.AspNetCore.Mvc;

    public class UsersController : AdministrationController
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new UsersListViewModel
            {
                Users = await this.usersService.GetAllAsync<UserViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
