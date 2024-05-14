namespace Models.Hangfire;

public class HangfireRequest
{
    public required string JobName { get; set; }

    public required string Email { get; set; }

    public RecurringOption CronExpression { get; set; }


}