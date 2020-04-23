namespace BeautyBooking.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Common.Models;

    public class BlogPost : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.DataValidations.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.ContentMaxLength)]
        public string Content { get; set; }

        // BlogPost can be created only in the Admin Dashboard
        // so the Author is not a User, just a string for name
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Author { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
