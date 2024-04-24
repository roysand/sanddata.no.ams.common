using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sanddata.no.ams.common.Domain.Entities;

namespace sanddata.no.ams.common.Infrastructure.Persistence.Configuration;

public class RawConfiguration : IEntityTypeConfiguration<RawData>
{
    public void Configure(EntityTypeBuilder<RawData> builder)
    {
        builder
            .HasNoKey()
            .ToTable("raw");

        builder.Property(e => e.Location)
            .HasMaxLength(50)
            .IsUnicode(false);
        builder.Property(e => e.Raw1)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("Raw");
        builder.Property(e => e.TimeStamp).HasPrecision(3);
    }
}