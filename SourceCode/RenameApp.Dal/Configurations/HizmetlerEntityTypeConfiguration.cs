using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class HizmetlerEntityTypeConfiguration : IEntityTypeConfiguration<Hizmetler>
    {
        public void Configure(EntityTypeBuilder<Hizmetler> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Base)
                .WithMany(x => x.Bases)
                .HasForeignKey(x => x.BaseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Hizmetlers)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsUnicode(true);

            builder
                .Property(x => x.BaseId)
                .HasColumnName("BaseId");

            builder
                .Property(x => x.SubName)
                .HasColumnName("SubName")
                .IsUnicode(true);

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId");

            builder
                .ToTable("Hizmetler", "dbo");
        }
    }
}
