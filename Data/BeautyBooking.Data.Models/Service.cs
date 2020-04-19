namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            this.Salons = new HashSet<SalonService>();
            this.Appointments = new HashSet<Appointment>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<SalonService> Salons { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
