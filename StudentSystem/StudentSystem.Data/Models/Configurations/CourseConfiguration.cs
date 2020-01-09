namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static DataValidations;

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.HasKey(key => key.CourseId);

            course.HasOne(t => t.Teacher)
                .WithMany(c => c.Courses)
                .HasForeignKey(fk => fk.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            course.Property(n => n.Name)
                .HasMaxLength(COURSE_NAME_MAX_LENGTH)
                .IsRequired(true)
                .IsUnicode(true);

            course.Property(t => t.TeacherId)
                .IsRequired(true);
        }
    }
}
