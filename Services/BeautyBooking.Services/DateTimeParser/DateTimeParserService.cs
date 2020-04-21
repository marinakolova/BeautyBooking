namespace BeautyBooking.Services.DateTimeParser
{
    using System;
    using System.Globalization;

    public class DateTimeParserService : IDateTimeParserService
    {
        public DateTime ConvertString(string date, string time)
        {
            string dateString = date + " " + time;
            string format = "dd-MM-yyyy h:mmtt";

            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            return dateTime;
        }
    }
}
