namespace Models.Hangfire;

public class HangfireRequest
{
    public string JobName { get; set; }
    public RecurringOption CronExpression { get; set; }


}