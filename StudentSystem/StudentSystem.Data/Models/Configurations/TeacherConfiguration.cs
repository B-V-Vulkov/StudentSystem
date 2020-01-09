namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> teacher)
        {
            teacher.HasKey(key => key.TeacherId);

            teacher.HasOne(u => u.User)
                .WithOne(t => t.Teacher)
                .HasForeignKey<User>(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            teacher.Property(u => u.UserId)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
