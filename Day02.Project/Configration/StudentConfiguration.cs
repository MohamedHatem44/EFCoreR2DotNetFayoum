using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Project.Configration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Fluent API
            builder.HasKey(s => s.StdId);

            builder.Property(s => s.StdName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(s=>s.Email)
                .HasMaxLength(100)
                .IsRequired();

             builder.Property(s => s.Age)
                .HasDefaultValue(18);

             builder.Property(s => s.DOF)
                .HasColumnType("date");
        }
    }
}
