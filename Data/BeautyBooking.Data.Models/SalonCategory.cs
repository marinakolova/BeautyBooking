namespace BeautyBooking.Data.Models
{
    using BeautyBooking.Data.Common.Models;

    public class SalonCategory : BaseDeletableModel<int>
    {
        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int CategoryId { get; set; }

        public virtual Category GetCategory { get; set; }
    }
}
