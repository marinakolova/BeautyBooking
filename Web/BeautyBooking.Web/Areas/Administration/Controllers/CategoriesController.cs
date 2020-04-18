namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Web.ViewModels.Administration.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : AdministrationController
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

        [HttpGet]
        public IActionResult AddCategory()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInputModel input)
        {
            await this.categoriesService.AddCategoryAsync(input.Name, input.Description, input.Image);

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Categories)
            {
                return this.RedirectToAction("Index");
            }

            await this.categoriesService.DeleteCategoryAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
