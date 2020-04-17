namespace BeautyBooking.Data.Models
{
    using BeautyBooking.Data.Common.Models;

    public class SalonService : BaseDeletableModel<int>
    {
        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public bool Available { get; set; }

        public double? Price { get; set; }
    }
}
