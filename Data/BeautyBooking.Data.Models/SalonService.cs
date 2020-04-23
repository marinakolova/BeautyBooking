namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Data.Common.Models;

    public class SalonService : BaseDeletableModel<int>
    {
        public SalonService()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        [Required]
        public string SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        // Each Salon gets all Services from its Category, but may not provide them all
        public bool Available { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
