using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class PhoneBookEntryConfig : IEntityTypeConfiguration<PhoneBookEntry>
    {
        public void Configure(EntityTypeBuilder<PhoneBookEntry> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(500).IsRequired();
        }
    }
}