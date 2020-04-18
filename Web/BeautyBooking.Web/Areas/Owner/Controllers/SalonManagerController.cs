namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Owner.SalonManager;
    using Microsoft.AspNetCore.Mvc;

    public class SalonManagerController : OwnerBaseController
    {
        private readonly ISalonsService salonsService;

        public SalonManagerController(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddSalon()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            await this.salonsService.AddSalonAsync(input.Name, input.Address, input.Image, input.CategoryId);

            return this.Redirect("/Home/Index");
        }
    }
}
