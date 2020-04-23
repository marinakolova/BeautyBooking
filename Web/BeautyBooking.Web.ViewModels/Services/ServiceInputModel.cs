namespace BeautyBooking.Web.ViewModels.Services
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;

    public class ServiceInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; } // TODO: Get it with name and id for the select list

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.DescriptionMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Description,
            MinimumLength = GlobalConstants.DataValidations.DescriptionMinLength)]
        public string Description { get; set; }
    }
}
