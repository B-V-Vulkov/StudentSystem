namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> studentCourse)
        {
            studentCourse.HasKey(key => new { key.CourseId, key.StudentId });

            studentCourse.HasOne(s => s.Student)
                .WithMany(ce => ce.CoursesEnrolled)
                .HasForeignKey(fk => fk.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            studentCourse.HasOne(c => c.Course)
                .WithMany(se => se.StudentsEnrolled)
                .HasForeignKey(fk => fk.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
