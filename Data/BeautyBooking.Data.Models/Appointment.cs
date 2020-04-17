namespace BeautyBooking.Data.Models
{
    using System;

    using BeautyBooking.Data.Common.Models;

    public class Appointment : BaseDeletableModel<int>
    {
        public DateTime Time { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public string ClientId { get; set; }

        public virtual ApplicationUser Client { get; set; }
    }
}
