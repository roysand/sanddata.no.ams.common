namespace DataLayer.Domain.Common;

public abstract class AuditableEntity
{
    public DateTime? Modified { get; set; }
}