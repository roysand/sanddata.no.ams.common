using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sanddata.no.ams.common.Domain.Entities;

namespace sanddata.no.ams.common.Infrastructure.Persistence.Configuration;

public class MinuteConfiguration : IEntityTypeConfiguration<Minute>
{
    public void Configure(EntityTypeBuilder<Minute> builder)
    {
        throw new NotImplementedException();
    }
}