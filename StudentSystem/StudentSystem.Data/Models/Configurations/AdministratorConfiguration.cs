namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> administrator)
        {
            administrator.HasKey(key => key.AdministratorId);

            administrator.HasOne(u => u.User)
                .WithOne(a => a.Administrator)
                .HasForeignKey<User>(fk => fk.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            administrator.Property(u => u.UserId)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
