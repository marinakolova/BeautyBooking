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

        public IActionResult Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons =
                    this.salonsService.GetAll<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult RegisterSalon()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterSalon(SalonInputModel input)
        {
            await this.salonsService.RegisterSalonAsync(input.Name, input.Address, input.Image, input.CategoryId);

            return this.Redirect("/Home/Index");
        }
    }
}
