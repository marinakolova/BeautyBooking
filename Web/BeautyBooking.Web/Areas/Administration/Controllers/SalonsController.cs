namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Services.Data.Services;
    using BeautyBooking.Web.ViewModels.Administration.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;
        private readonly ICitiesService citiesService;
        private readonly IServicesService servicesService;
        private readonly ISalonServicesService salonServicesService;

        public SalonsController(
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
            var categoriesNames = await this.categoriesService.GetAllNamesAsync();
            var citiesNames = await this.citiesService.GetAllNamesAsync();

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
            var salonId = await this.salonsService.AddAsync(input.Name, categoryId, cityId, input.Address, input.Image);

            // Add to the Salon all Services from its Category
            var servicesIds = await this.servicesService.GetAllByCategoryAsync(categoryId);
            await this.salonServicesService.AddAsync(salonId, servicesIds);

            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSalon(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Salons)
            {
                return this.RedirectToAction("Index");
            }

            await this.salonsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
