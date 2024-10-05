using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class ServiceReceiversEntityTypeConfiguration : IEntityTypeConfiguration<ServiceReceivers>
    {
        public void Configure(EntityTypeBuilder<ServiceReceivers> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.ServiceReceiverss)
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
                .Property(x => x.LastServiceDate)
                .HasColumnName("LastServiceDate")
                .HasColumnType("date");

            builder
                .ToTable("ServiceReceivers", "dbo");
        }
    }
}
