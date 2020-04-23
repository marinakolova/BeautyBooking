namespace BeautyBooking.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Data.Common.Models;

    public class Appointment : BaseDeletableModel<string>
    {
        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public virtual SalonService SalonService { get; set; }

        // The Salon can Confirm or Decline an appointment
        public bool? Confirmed { get; set; }

        // For every past (and confirmed) appointment the User can Rate the Salon
        // But rating can be given only once for each appointment
        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
