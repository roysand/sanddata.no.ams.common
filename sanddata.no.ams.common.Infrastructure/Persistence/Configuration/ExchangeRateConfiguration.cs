using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sanddata.no.ams.common.Domain.Entities;

namespace sanddata.no.ams.common.Infrastructure.Persistence.Configuration;

public class ExchangeRateConfiguration : IEntityTypeConfiguration<ExchangeRate>
{
    public void Configure(EntityTypeBuilder<ExchangeRate> builder)
    {
        builder
            .HasNoKey()
            .ToTable("exchange_rate");

        builder.HasIndex(e => e.ExchangeRatePeriod, "IX_exchange_rate_exchangerateperiod");

        builder.HasIndex(e => e.ExchangeRateId, "uk_exchange_rate").IsUnique();

        builder.Property(e => e.ExchangeRate1)
            .HasColumnType("decimal(19, 5)")
            .HasColumnName("ExchangeRate");
        builder.Property(e => e.ExchangeRatePeriod).HasPrecision(3);
    }
}