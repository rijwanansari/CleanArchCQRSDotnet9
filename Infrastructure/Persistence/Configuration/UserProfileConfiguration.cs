
using Domain.Aggregates.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.ToTable("UserProfiles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(x => x.IsMarried)
            .IsRequired();

        builder.Property(x => x.Address)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.City)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.State)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Country)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.ZipCode)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(x => x.SpouseFirstName)
            .HasMaxLength(50);

        builder.Property(x => x.SpouseLastName)
            .HasMaxLength(50);

        builder.Property(x => x.SpouseEmail)
            .HasMaxLength(100);

        builder.Property(x => x.SpousePhoneNumber)
            .HasMaxLength(15);
                

        
    }

}
