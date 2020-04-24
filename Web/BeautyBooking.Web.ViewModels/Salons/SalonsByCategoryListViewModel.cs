namespace BeautyBooking.Web.ViewModels.Salons
{
    using System.Collections.Generic;

    public class SalonsByCategoryListViewModel
    {
        public IEnumerable<SalonViewModel> Salons { get; set; }

        // For the View Title
        public string CategoryName { get; set; }

        // To check for case of new added (not seeded) category with no salons
        public int SalonsCount { get; set; }
    }
}
