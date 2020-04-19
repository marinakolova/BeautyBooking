namespace BeautyBooking.Data.Models
{
    using System;

    using BeautyBooking.Data.Common.Models;

    public class Appointment : BaseDeletableModel<int>
    {
        public DateTime Time { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public virtual SalonService SalonService { get; set; }
    }
}
