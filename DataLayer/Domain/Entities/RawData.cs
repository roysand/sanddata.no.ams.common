namespace DataLayer.Domain.Entities;

public class RawData
{
    public Guid MeasurementId { get; set; }
    public DateTime TimeStamp { get; set; }
    public string Raw { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public bool IsNew { get; set; }

    public RawData()
    {
        IsNew = false;
    }
}