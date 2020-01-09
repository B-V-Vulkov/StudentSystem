namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(key => key.StudentId);

            student.HasOne(u => u.User)
                .WithOne(s => s.Student)
                .HasForeignKey<User>(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            student.Property(u => u.UserId)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
