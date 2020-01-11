namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> department)
        {
            department.HasMany(u => u.Users)
                .WithOne(t => t.Department)
                .OnDelete(DeleteBehavior.Restrict);

            department.Property(t => t.DepartmentId)
                .UseIdentityColumn(1, 1);
        }
    }
}
