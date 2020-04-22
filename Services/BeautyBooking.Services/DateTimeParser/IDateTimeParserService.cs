namespace BeautyBooking.Services.DateTimeParser
{
    using System;

    public interface IDateTimeParserService
    {
        DateTime ConvertStrings(string date, string time);
    }
}
