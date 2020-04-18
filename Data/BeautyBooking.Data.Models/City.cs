namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class City : BaseDeletableModel<int>
    {
        public City()
        {
            this.Salons = new HashSet<Salon>();
        }

        public string Name { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
    }
}
