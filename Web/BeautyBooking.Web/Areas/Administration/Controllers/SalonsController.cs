namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Services.Data.Services;
    using BeautyBooking.Web.ViewModels.Salons;
    using BeautyBooking.Web.ViewModels.SelectLists;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

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
            var categories = await this.categoriesService.GetAllAsync<CategorySelectListViewModel>();
            var cities = await this.citiesService.GetAllAsync<CitySelectListViewModel>();

            this.ViewData["Categories"] = new SelectList(categories, "Id", "Name");
            this.ViewData["Cities"] = new SelectList(cities, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            try
            {
                // Add Salon
                var salonId = await this.salonsService.AddAsync(input.Name, input.CategoryId, input.CityId, input.Address, input.Image);

                // Add to the Salon all Services from its Category
                var servicesIds = await this.servicesService.GetAllByCategoryAsync(input.CategoryId); // TODO: Refactor this
                await this.salonServicesService.AddAsync(salonId, servicesIds);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                return this.RedirectToAction("Index");
                throw;
            }

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSalon(string id)
        {
            if (id.StartsWith("seeded"))
            {
                return this.RedirectToAction("Index");
            }

            await this.salonsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
