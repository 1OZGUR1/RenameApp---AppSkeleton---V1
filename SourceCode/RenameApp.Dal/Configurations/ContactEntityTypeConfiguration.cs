using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Adress)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.AdressId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.SocialAdres)
                .WithMany(x => x.SocialAdress)
                .HasForeignKey(x => x.SocialAdresId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.AdressId)
                .HasColumnName("AdressId");

            builder
                .Property(x => x.Gsm)
                .HasColumnName("Gsm")
                .HasColumnType("nchar")
                .IsUnicode(true)
                .IsFixedLength();

            builder
                .Property(x => x.SocialAdresId)
                .HasColumnName("SocialAdresId");

            builder
                .Property(x => x.Email)
                .HasColumnName("Email")
                .IsUnicode(true);

            builder
                .ToTable("Contact", "dbo");
        }
    }
}
