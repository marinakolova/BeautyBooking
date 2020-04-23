namespace BeautyBooking.Web.ViewModels.Cities
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;

    public class CityInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }
    }
}
