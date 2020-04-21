namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonViewModel : IMapFrom<Salon>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public virtual ICollection<SalonServicesViewModel> Services { get; set; }

        public virtual ICollection<SalonAppointmentsViewModel> Appointments { get; set; }
    }
}
