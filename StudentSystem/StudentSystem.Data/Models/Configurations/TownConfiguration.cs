namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> town)
        {
            town.HasMany(u => u.Users)
                .WithOne(t => t.Town)
                .OnDelete(DeleteBehavior.Restrict);

            town.Property(t => t.TownId)
                .UseIdentityColumn(1, 1);
        }
    }
}
