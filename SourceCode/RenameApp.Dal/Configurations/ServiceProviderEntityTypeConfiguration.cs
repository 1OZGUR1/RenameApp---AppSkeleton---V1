using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class ServiceProviderEntityTypeConfiguration : IEntityTypeConfiguration<ServiceProvider>
    {
        public void Configure(EntityTypeBuilder<ServiceProvider> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.ServiceProviders)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId");

            builder
                .Property(x => x.ServicesId)
                .HasColumnName("ServicesId")
                .IsUnicode(true);

            builder
                .Property(x => x.Rating)
                .HasColumnName("Rating")
                .HasColumnType("nchar")
                .IsUnicode(true)
                .IsFixedLength();

            builder
                .ToTable("ServiceProvider", "dbo");
        }
    }
}
