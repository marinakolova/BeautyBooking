namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Salon : BaseDeletableModel<int>
    {
        public Salon()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Categories = new HashSet<SalonCategory>();
            this.Services = new HashSet<SalonService>();
        }

        public string Name { get; set; }

        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<SalonCategory> Categories { get; set; }

        public virtual ICollection<SalonService> Services { get; set; }
    }
}
