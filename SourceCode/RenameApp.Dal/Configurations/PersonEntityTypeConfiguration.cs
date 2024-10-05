using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Persons)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.ServiceProviderId)
                .HasColumnName("ServiceProviderId")
                .IsUnicode(true);

            builder
                .Property(x => x.SurName)
                .HasColumnName("SurName")
                .HasColumnType("nchar")
                .IsUnicode(true)
                .IsFixedLength();

            builder
                .Property(x => x.CitizenshipNumber)
                .HasColumnName("CitizenshipNumber")
                .HasColumnType("varchar")
                .IsUnicode(false);

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId");

            builder
                .ToTable("Person", "dbo");
        }
    }
}
