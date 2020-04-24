namespace BeautyBooking.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesSimpleListViewComponent : ViewComponent
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesSimpleListViewComponent(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new CategoriesSimpleListViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<CategorySimpleViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
