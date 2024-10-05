using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class OrderStaticsEntityTypeConfiguration : IEntityTypeConfiguration<OrderStatics>
    {
        public void Configure(EntityTypeBuilder<OrderStatics> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Order1)
                .WithMany(x => x.OrderStaticss)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder
            //    .HasOne(x => x.Order)
            //    .WithMany(x => x.OrderStaticss)
            //    .HasForeignKey(x => x.OrderId1)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.OrderId)
                .HasColumnName("OrderId");

            builder
                .Property(x => x.OrderId1)
                .HasColumnName("OrderId");

            builder
                .Property(x => x.OrderSuccessRating)
                .HasColumnName("OrderSuccessRating")
                .IsUnicode(true);

            builder
                .Property(x => x.ServiceResiverComment)
                .HasColumnName("ServiceResiverComment")
                .IsUnicode(true);

            builder
                .Property(x => x.ServiceProviderComment)
                .HasColumnName("ServiceProviderComment")
                .IsUnicode(true);

            builder
                .ToTable("OrderStatics", "dbo");
        }
    }
}
