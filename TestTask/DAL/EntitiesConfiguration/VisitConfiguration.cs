using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfiguration
{
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder
                .ToTable("Visits")
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.City)
                .WithMany(x => x.Visits)
                .HasForeignKey(x => x.CityId);
        }
    }
}
