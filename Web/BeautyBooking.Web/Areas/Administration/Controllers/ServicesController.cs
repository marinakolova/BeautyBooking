namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Services.Data.Services;
    using BeautyBooking.Web.ViewModels.Administration.Services;
    using Microsoft.AspNetCore.Mvc;

    public class ServicesController : AdministrationController
    {
        private readonly IServicesService servicesService;

        public ServicesController(IServicesService servicesService)
        {
            this.servicesService = servicesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new ServicesListViewModel
            {
                Services = await this.servicesService.GetAllAsync<ServiceViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddService()
        {
            return this.View();
        }

        // [HttpPost]
        // public async Task<IActionResult> AddCategory(CategoryInputModel input)
        // {
        //     await this.categoriesService.AddCategoryAsync(input.Name, input.Description, input.Image);
        //
        //     return this.RedirectToAction("Index");
        // }
        public async Task<IActionResult> DeleteService(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Services)
            {
                return this.RedirectToAction("Index");
            }

            await this.servicesService.DeleteServiceAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
