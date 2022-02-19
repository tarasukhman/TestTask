using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Models;

namespace TestTask.ModelsConfiguration
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
