namespace BeautyBooking.Services.DateTimeParser
{
    using System;

    public interface IDateTimeParserService
    {
        DateTime ConvertString(string date, string time);

        string ConvertToString(DateTime dateTime);
    }
}
