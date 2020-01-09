namespace StudentSystem.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static DataValidations;

    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> town)
        {
            town.HasKey(key => key.TownId);

            town.Property(n => n.Name)
                .HasMaxLength(DEPARTMENT_NAME_MAX_LENGTH)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
