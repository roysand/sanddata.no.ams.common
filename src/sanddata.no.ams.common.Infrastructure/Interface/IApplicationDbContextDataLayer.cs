using Microsoft.EntityFrameworkCore;
using sanddata.no.ams.common.Domain.Entities;

namespace sanddata.no.ams.common.Infrastructure.Interface;

public interface IApplicationDbContextDataLayer
{
    DbSet<RawData> RawSet { get; set; }
    DbSet<Detail> DetailSet { get; set; }
    DbSet<Minute> MinuteSet { get; set; }
    DbSet<Hour> HourSet { get; set; }
    DbSet<Price> PriceSet { get; set; }
    DbSet<PriceDetail> PriceDetailSet { get; set; }
    DbSet<ExchangeRate> ExchangeRateSet { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}