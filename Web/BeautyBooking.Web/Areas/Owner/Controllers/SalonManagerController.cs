namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Owner.SalonManager;
    using Microsoft.AspNetCore.Mvc;

    public class SalonManagerController : OwnerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;
        private readonly ICitiesService citiesService;

        public SalonManagerController(ISalonsService salonsService, ICategoriesService categoriesService, ICitiesService citiesService)
        {
            this.salonsService = salonsService;
            this.categoriesService = categoriesService;
            this.citiesService = citiesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> AddSalon()
        {
            var categoriesNames = await this.categoriesService.GetAllCategoriesNamesAsync();
            var citiesNames = await this.citiesService.GetAllCitiesNamesAsync();

            this.ViewData["Categories"] = categoriesNames;
            this.ViewData["Cities"] = citiesNames;

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            var category = await this.categoriesService.GetByNameAsync<CategoryForSalonInputModel>(input.Category);
            var city = await this.citiesService.GetByNameAsync<CityForSalonInputModel>(input.City);

            await this.salonsService.AddSalonAsync(input.Name, category.Id, city.Id, input.Address, input.Image);

            return this.Redirect("/Home/Index");
        }
    }
}
