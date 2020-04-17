namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Salon : BaseDeletableModel<int>
    {
        public Salon()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Services = new HashSet<SalonService>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<SalonService> Services { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
