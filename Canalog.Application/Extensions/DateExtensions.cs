public static class DateExtensions
{
    public static DateTimeOffset StartOfWeek(this DateTimeOffset dt, DayOfWeek startOfWeek)
    {
        int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        var result = dt.AddDays(-1 * diff);
        return new DateTimeOffset(result.Date, result.Offset);
    }
}
