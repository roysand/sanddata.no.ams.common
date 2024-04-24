﻿namespace sanddata.no.ams.common.Domain.Entities;

public class Hour
{
    public DateTime TimeStamp { get; set; }

    public string Location { get; set; } = null!;

    public string? Unit { get; set; }

    public decimal? ValueNum { get; set; }

    public short? Count { get; set; }
}