
using System.ComponentModel;
using Hangfire;

namespace Models.Hangfire.Enums;

public enum CronOptionEnum
{
    Minutely,
    Hourly,
    Daily,
    Weekly,
    Monthly,
    Yearly,
    Never
}

public static class CronOptionEnumExtensions
{
    /// <summary>
    /// Turns the CronOptionEnum into a Cron expression string
    /// </summary>
    /// <param name="cronOption"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static string ToCronExpression(this CronOptionEnum cronOption)
    {
        switch (cronOption)
        {
            case CronOptionEnum.Minutely: return Cron.Minutely();
            case CronOptionEnum.Hourly: return Cron.Hourly();
            case CronOptionEnum.Daily: return Cron.Daily();
            case CronOptionEnum.Weekly: return Cron.Weekly();
            case CronOptionEnum.Monthly: return Cron.Monthly();
            case CronOptionEnum.Yearly: return Cron.Yearly();
            case CronOptionEnum.Never: return Cron.Never();
            default: throw new ArgumentOutOfRangeException(nameof(cronOption));
        }
    }
}