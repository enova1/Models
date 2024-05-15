using Models.Hangfire.Enums;

namespace Models.Hangfire;

public class JobRequest
{
    public required int ClientId { get; set; }

    public required string JobName { get; set; }

    public string? Email { get; set; }

    /// <summary>
    /// CronOptionEnum (hangfire.Cron) to set the Cron by option
    /// </summary>
    public string? CronOption { get; set; }

    /// <summary>
    /// Pass in the CronExpression to set the Cron by expression
    /// </summary>
    public CronExpressionModel? CronExpression { get; set; }

}