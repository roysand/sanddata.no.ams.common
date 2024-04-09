namespace DataLayer.Domain.Entities;

public class Hour
{
    public DateTime TimeStamp { get; set; }
    public string Location { get; set; } = String.Empty;
    public string Unit { get; set; } = string.Empty;
    public decimal ValueNum { get; set; }
    public short Count { get; set; }
}