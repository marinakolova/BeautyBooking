namespace BeautyBooking.Data.Models
{
    using System;

    using BeautyBooking.Data.Common.Models;

    public class Appointment : BaseDeletableModel<int>
    {
        public DateTime Time { get; set; }

        public int SalonId { get; set; }

        public Salon Salon { get; set; }

        public string ClientId { get; set; }

        public ApplicationUser Client { get; set; }
    }
}
