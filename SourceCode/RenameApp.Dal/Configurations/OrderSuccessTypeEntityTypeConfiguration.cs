using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class OrderSuccessTypeEntityTypeConfiguration : IEntityTypeConfiguration<OrderSuccessType>
    {
        public void Configure(EntityTypeBuilder<OrderSuccessType> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.OrderSuccessType1)
                .HasColumnName("OrderSuccessType")
                .IsUnicode(true);

            builder
                .ToTable("OrderSuccessType", "dbo");
        }
    }
}
