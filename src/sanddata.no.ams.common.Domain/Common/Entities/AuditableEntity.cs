﻿namespace sanddata.no.ams.common.Domain.Common.Entities;

public abstract class AuditableEntity
{
    public DateTime? Modified { get; set; }
}