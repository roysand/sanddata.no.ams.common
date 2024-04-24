using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sanddata.no.ams.common.Domain.Entities;
using sanddata.no.ams.common.Infrastructure.Interface;

namespace sanddata.no.ams.common.Infrastructure.Persistence;

public partial class ApplicationDbContextDataLayer(
    IConfigDataLayer configDataLayer,
    ILoggerFactory loggerFactory)
    : DbContext, IApplicationDbContextDataLayer
{
    public DbSet<RawData> RawSet { get; set; } = null!;
    public DbSet<Detail> DetailSet { get; set; } = null!;
    public DbSet<Minute> MinuteSet { get; set; } = null!;
    public DbSet<Hour> HourSet { get; set; } = null!;
    public DbSet<Price> PriceSet { get; set; } = null!;
    public DbSet<PriceDetail> PriceDetailSet { get; set; } = null!;
    public DbSet<ExchangeRate> ExchangeRateSet { get; set; } = null!;

    public async Task<int> SaveChanges(CancellationToken cancellationToken)
    {
        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var sqlTimeout = 600;
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString =
                configDataLayer.ApplicationSettingsConfigDataLayer.DbConnectionString();
            optionsBuilder.UseSqlServer(connectionString,
                    opts => opts.CommandTimeout(sqlTimeout))
                .EnableSensitiveDataLogging(true)
                .EnableDetailedErrors(true)
                .UseLoggerFactory(loggerFactory);
        }

        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}