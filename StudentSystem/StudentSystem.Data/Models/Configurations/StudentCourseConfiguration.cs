namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> studentCourse)
        {
            studentCourse.HasKey(key => new { key.StudentId, key.CourseId });

            studentCourse.HasOne(s => s.Student)
                .WithMany(ce => ce.CoursesEnrolled)
                .OnDelete(DeleteBehavior.Restrict);

            studentCourse.HasOne(c => c.Course)
                .WithMany(se => se.StudentsEnrolled)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
