namespace BeautyBooking.Web.ViewModels.Salons
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;
    using BeautyBooking.Web.ViewModels.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class SalonInputModel
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
        public string City { get; set; } // TODO: Get it with name and id for the select list

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.AddressMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Address,
            MinimumLength = GlobalConstants.DataValidations.AddressMinLength)]
        public string Address { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }
    }
}
