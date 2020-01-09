namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static DataValidations;

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> department)
        {
            department.HasKey(key => key.DepartmentId);

            department.Property(n => n.Name)
                .HasMaxLength(DEPARTMENT_NAME_MAX_LENGTH)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
