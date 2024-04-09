namespace DataLayer.Domain.Entities;

public class Minute
{
    public DateTime TimeStamp { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public decimal ValueNum { get; set; }
    public short Count { get; set; }
}