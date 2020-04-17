namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            this.Salons = new HashSet<SalonService>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SalonService> Salons { get; set; }
    }
}
