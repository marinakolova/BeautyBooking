namespace BeautyBooking.Web.Controllers
{
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories =
                    this.categoriesService.GetAll<CategoryViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
