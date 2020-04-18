namespace BeautyBooking.Web.Areas.Owner.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Services.Data.Services;
    using BeautyBooking.Web.ViewModels.Owner.SalonManager;
    using Microsoft.AspNetCore.Mvc;

    public class SalonManagerController : OwnerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;
        private readonly ICitiesService citiesService;
        private readonly IServicesService servicesService;
        private readonly ISalonServicesService salonServicesService;

        public SalonManagerController(
            ISalonsService salonsService,
            ICategoriesService categoriesService,
            ICitiesService citiesService,
            IServicesService servicesService,
            ISalonServicesService salonServicesService)
        {
            this.salonsService = salonsService;
            this.categoriesService = categoriesService;
            this.citiesService = citiesService;
            this.servicesService = servicesService;
            this.salonServicesService = salonServicesService;
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
            // Get CategoryId and CityId
            var categoryId = await this.categoriesService.GetIdByNameAsync(input.Category);
            var cityId = await this.citiesService.GetIdByNameAsync(input.City);

            // Add Salon
            var salonId = await this.salonsService.AddSalonAsync(input.Name, categoryId, cityId, input.Address, input.Image);

            // Get Services for the Salon from the Category
            var servicesIds = await this.servicesService.GetAllServicesInCategoryAsync(categoryId);

            // Add SalonServices
            await this.salonServicesService.AddSalonServicesAsync(salonId, servicesIds);

            return this.Redirect("/Home/Index");
        }
    }
}
