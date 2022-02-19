using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Models;

namespace TestTask.ModelsConfiguration
{
    public class VisitorConfiguration : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            builder
                .ToTable("Visitors")
                .HasKey(x => x.Id);
        }
    }
}
