namespace Models;

public class PayRun
{
    public int Id { get; set; }
    public int PayPeriodId { get; set; }
    public int PayRunStatusId { get; set; }
    public int PayRunTypeId { get; set; }
    public int PayRunFrequencyId { get; set; }
    public int PayRunMethodId { get; set; }
    public int PayRunPeriodId { get; set; }
    public int PayRunYear { get; set; }
    public int PayRunNumber { get; set; }
    public int PayRunMonth { get; set; }
    public int PayRunWeek { get; set; }
    public int PayRunDay { get; set; }
}