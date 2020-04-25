namespace BeautyBooking.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Categories;
    using BeautyBooking.Web.ViewModels.Common.Pagination;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : BaseController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;

        public SalonsController(
            ISalonsService salonsService,
            ICategoriesService categoriesService)
        {
            this.salonsService = salonsService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index(
            int? sortId, // categoryId
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            if (sortId != null)
            {
                var category = await this.categoriesService
                    .GetByIdAsync<CategorySimpleViewModel>(sortId.Value);
                if (category == null)
                {
                    return new StatusCodeResult(404);
                }

                this.ViewData["CategoryName"] = category.Name;
            }

            this.ViewData["CurrentSort"] = sortId;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            this.ViewData["CurrentFilter"] = searchString;

            int pageSize = PageSizesConstants.Salons;
            var pageIndex = pageNumber ?? 1;

            var salons = await this.salonsService
                .GetAllWithSortingFilteringAndPagingAsync<SalonViewModel>(
                    searchString, sortId, pageSize, pageIndex);
            var salonsList = salons.ToList();

            var count = await this.salonsService
                .GetCountForPaginationAsync(searchString, sortId);

            var viewModel = new SalonsPaginatedListViewModel
            {
                Salons = new PaginatedList<SalonViewModel>(salonsList, count, pageIndex, pageSize),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonWithServicesViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
