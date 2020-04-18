namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class SalonService : BaseDeletableModel<int>
    {
        public SalonService()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public bool Available { get; set; }

        public double? Price { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
