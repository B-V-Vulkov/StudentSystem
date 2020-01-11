namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> administrator)
        {
            administrator.HasOne(u => u.User)
                .WithOne(a => a.Administrator)
                .OnDelete(DeleteBehavior.Restrict);

            administrator.Property(t => t.AdministratorId)
                .UseIdentityColumn(1, 1);
        }
    }
}
