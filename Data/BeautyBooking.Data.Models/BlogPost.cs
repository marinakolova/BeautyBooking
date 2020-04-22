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

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Author { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
