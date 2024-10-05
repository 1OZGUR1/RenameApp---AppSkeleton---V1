using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class IlceEntityTypeConfiguration : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.IlceSehir)
                .WithMany(x => x.IlceSehirs)
                .HasForeignKey(x => x.SehirFk)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.Ad)
                .HasColumnName("Ad")
                .IsUnicode(true);

            builder
                .Property(x => x.SehirFk)
                .HasColumnName("SehirFk");

            builder
                .ToTable("Ilce", "dbo");
        }
    }
}
