using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfiguration
{
    public class VisitVisitorsConfiguration : IEntityTypeConfiguration<VisitVisitor>
    {
        public void Configure(EntityTypeBuilder<VisitVisitor> builder)
        {
            builder.HasKey(x => new { x.VisitId, x.VisitorId });

            builder
                .HasOne(x => x.Visitor)
                .WithMany(x => x.VisitVisitors)
                .HasForeignKey(x => x.VisitorId);

            builder
                .HasOne(x => x.Visit)
                .WithMany(x => x.VisitVisitors)
                .HasForeignKey(x => x.VisitId);
        }
    }
}
