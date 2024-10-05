using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class CorporateEntityTypeConfiguration : IEntityTypeConfiguration<Corporate>
    {
        public void Configure(EntityTypeBuilder<Corporate> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Corporates)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.ServiceProviderId)
                .HasColumnName("ServiceProviderId")
                .IsUnicode(true);

            builder
                .Property(x => x.TradeRegistryNumber)
                .HasColumnName("TradeRegistryNumber")
                .IsUnicode(true);

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId");

            builder
                .ToTable("Corporate", "dbo");
        }
    }
}
