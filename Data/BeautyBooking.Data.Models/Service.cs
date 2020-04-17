namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
