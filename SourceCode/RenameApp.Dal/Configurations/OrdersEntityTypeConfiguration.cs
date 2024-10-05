using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class OrdersEntityTypeConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.ServiceProvider)
                .WithMany(x => x.ServiceProviders)
                .HasForeignKey(x => x.ServiceProviderId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.ServiceResiver)
                .WithMany(x => x.ServiceResivers)
                .HasForeignKey(x => x.ServiceResiverId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.Adress)
                .WithMany(x => x.Orderss)
                .HasForeignKey(x => x.AdressId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.OrdersOrderSuccessType)
                .WithMany(x => x.OrdersOrderSuccessTypes)
                .HasForeignKey(x => x.OrdersSuccsesType)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.ServiceProviderId)
                .HasColumnName("ServiceProviderId");

            builder
                .Property(x => x.ServiceResiverId)
                .HasColumnName("ServiceResiverId");

            builder
                .Property(x => x.AdressId)
                .HasColumnName("AdressId");

            builder
                .Property(x => x.OrdersSuccsesType)
                .HasColumnName("OrdersSuccsesType");

            builder
                .ToTable("Orders", "dbo");
        }
    }
}
