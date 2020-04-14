using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(k => k.Id);

            builder.HasIndex(i => i.Email).IsUnique();

            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);

            builder.Property(u => u.Email).HasMaxLength(100);
        }
    }
}
