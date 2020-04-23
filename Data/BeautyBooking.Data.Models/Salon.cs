namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Common.Models;

    public class Salon : BaseDeletableModel<string>
    {
        public Salon()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Services = new HashSet<SalonService>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        // Not Required! Allows testing/showing functionality with seeded data in Admin and Manager Areas
        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.AddressMaxLength)]
        public string Address { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<SalonService> Services { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
