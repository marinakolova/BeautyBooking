namespace BeautyBooking.Services.DateTimeParser
{
    using System;
    using System.Globalization;

    using BeautyBooking.Common;

    public class DateTimeParserService : IDateTimeParserService
    {
        public DateTime ConvertString(string date, string time)
        {
            string dateString = date + " " + time;
            string format = GlobalConstants.DateTimeFormats.DateTimeFormat;

            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            return dateTime;
        }

        public string ConvertToString(DateTime dateTime)
        {
            string format = "dd-MM-yyyy h:mmtt";

            return dateTime.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
