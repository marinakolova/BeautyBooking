namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Salon : BaseDeletableModel<int>
    {
        public Salon()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
