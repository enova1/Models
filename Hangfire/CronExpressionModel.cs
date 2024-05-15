
namespace Models.Hangfire;

public class CronExpressionModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="minute"></param>
    /// <param name="hour"></param>
    /// <param name="dayOfMonth"></param>
    /// <param name="month"></param>
    /// <param name="dayOfWeek"></param>
    /// <param name="year"></param>
    public CronExpressionModel(string minute = "*", string hour = "*", string dayOfMonth = "*", string month = "*", string dayOfWeek = "*")
    {
        Minute = minute;
        Hour = hour;
        DayOfMonth = dayOfMonth;
        Month = month;
        DayOfWeek = dayOfWeek;
    }

    private string Minute { get; set; }
    private string Hour { get; set; }
    private string DayOfMonth { get; set; }
    private string Month { get; set; }
    private string DayOfWeek { get; set; }

    /// <summary>
    /// Converts the CronExpressionModel to a string expression
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{Minute} {Hour} {DayOfMonth} {Month} {DayOfWeek}";
    }
}


