namespace DataLayer.Domain.Entities
{
    public class Detail
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid MeasurementId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ObisCode { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public string ValueStr { get; set; } = string.Empty;
        public decimal ValueNum { get; set; }
    }
}