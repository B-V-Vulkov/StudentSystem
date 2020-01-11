namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasOne(u => u.User)
                .WithOne(s => s.Student)
                .OnDelete(DeleteBehavior.Restrict);

            student.Property(t => t.StudentId)
                .UseIdentityColumn(1, 1);
        }
    }
}
