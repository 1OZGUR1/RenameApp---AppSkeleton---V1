using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Contact)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.ContactId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.UserName)
                .HasColumnName("UserName")
                .IsUnicode(true);

            builder
                .Property(x => x.Password)
                .HasColumnName("Password")
                .IsUnicode(true);

            builder
                .Property(x => x.Salt)
                .HasColumnName("Salt")
                .IsUnicode(true);

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nchar")
                .IsUnicode(true)
                .IsFixedLength();

            builder
                .Property(x => x.ContactId)
                .HasColumnName("ContactId");

            builder
                .ToTable("User", "dbo");
        }
    }
}
