namespace Moreno.PagFacil_Pos.UnityTests.Shared;

public static class DateTimeExtensions
{
    public static short ToYearLastTwoDigit(this DateTime dateTime)
    {
        var temp = dateTime.ToString("yy");
        return short.Parse(temp);
    }
}
