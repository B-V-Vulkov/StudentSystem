namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static DataValidations;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasKey(key => key.UserId);

            user.HasOne(t => t.Town)
                .WithMany(u => u.Users)
                .HasForeignKey(fk => fk.TownId);

            user.HasOne(d => d.Department)
                .WithMany(u => u.Users)
                .HasForeignKey(fk => fk.DepartmentId);

            user.Property(un => un.UserName)
                .HasMaxLength(USER_NAME_MAX_LENGTH)
                .IsRequired(true)
                .IsUnicode(true);

            user.Property(p => p.Password)
                .HasMaxLength(USER_PASSWORD_MAX_LENGTH)
                .IsRequired(true)
                .IsUnicode();

            user.Property(fn => fn.FirstName)
                .HasMaxLength(USER_FIRST_NAME_MAX_LENGTH)
                .IsRequired(true);

            user.Property(mn => mn.MiddleName)
                .HasMaxLength(USER_MIDDLE_NAME_MAX_LENGTH)
                .IsRequired(true);

            user.Property(ln => ln.LastName)
                .HasMaxLength(USER_LAST_NAME_MAX_LENGTH)
                .IsRequired(true);

            user.Property(d => d.DepartmentId)
                .IsRequired(true);

            user.Property(d => d.TownId)
                .IsRequired(false);
        }
    }
}
