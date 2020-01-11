namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.HasOne(t => t.Teacher)
                .WithMany(c => c.Courses)
                .OnDelete(DeleteBehavior.Restrict);

            course.Property(t => t.CourseId)
                .UseIdentityColumn(1, 1);
        }
    }
}
