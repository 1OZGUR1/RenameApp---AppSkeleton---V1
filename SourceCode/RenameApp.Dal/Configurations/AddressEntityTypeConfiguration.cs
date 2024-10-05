using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class AddressEntityTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.AddressIlce)
                .WithMany(x => x.AddressIlces)
                .HasForeignKey(x => x.IlceFk)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.IlceFk)
                .HasColumnName("IlceFk");

            builder
                .Property(x => x.AdressDetail)
                .HasColumnName("AdressDetail")
                .IsUnicode(true);

            builder
                .ToTable("Address", "dbo");
        }
    }
}
