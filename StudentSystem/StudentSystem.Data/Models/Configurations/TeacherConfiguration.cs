namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> teacher)
        {
            teacher.HasOne(u => u.User)
                .WithOne(t => t.Teacher)
                .OnDelete(DeleteBehavior.Restrict);

            teacher.Property(t => t.TeacherId)
                .UseIdentityColumn(1,1);
        }
    }
}
