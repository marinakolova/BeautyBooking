namespace BeautyBooking.Web.ViewModels.Common.CustomValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    using BeautyBooking.Common;

    public class ValidateTimeStringAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            var timeString = value as string;

            if (string.IsNullOrEmpty(timeString))
            {
                return false;
            }

            bool parsed = DateTime.TryParseExact(
                            timeString,
                            GlobalConstants.DateTimeFormats.TimeFormat,
                            CultureInfo.InvariantCulture,
                            style: DateTimeStyles.AssumeUniversal,
                            result: out _);
            if (!parsed)
            {
                return false;
            }

            return true;
        }
    }
}
