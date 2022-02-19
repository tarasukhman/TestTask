using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfiguration
{
    public class CountryVisitorConfiguration : IEntityTypeConfiguration<CountryVisitor>
    {
        public void Configure(EntityTypeBuilder<CountryVisitor> builder)
        {
            builder.HasKey(x => new {x.CountryId, x.VisitorId});

            builder
                .HasOne(x => x.Country)
                .WithMany(x => x.CountryVisitors)
                .HasForeignKey(x => x.CountryId);

            builder
                .HasOne(x => x.Visitor)
                .WithMany(x => x.CountryVisitors)
                .HasForeignKey(x => x.VisitorId);
        }
    }
}
