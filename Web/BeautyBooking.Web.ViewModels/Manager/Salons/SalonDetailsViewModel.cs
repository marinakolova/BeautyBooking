namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonDetailsViewModel : IMapFrom<Salon>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string CategoryName { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public virtual ICollection<SalonServiceViewModel> Services { get; set; }

        public virtual ICollection<SalonAppointmentViewModel> Appointments { get; set; }
    }
}
