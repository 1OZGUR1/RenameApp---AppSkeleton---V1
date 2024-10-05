using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class SocialAdresEntityTypeConfiguration : IEntityTypeConfiguration<SocialAdres>
    {
        public void Configure(EntityTypeBuilder<SocialAdres> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.YoutubeAdress)
                .HasColumnName("YoutubeAdress")
                .IsUnicode(true);

            builder
                .Property(x => x.TwitterAdress)
                .HasColumnName("TwitterAdress")
                .IsUnicode(true);

            builder
                .Property(x => x.WhatsapAdress)
                .HasColumnName("WhatsapAdress")
                .IsUnicode(true);

            builder
                .Property(x => x.FacebookAdress)
                .HasColumnName("FacebookAdress")
                .IsUnicode(true);

            builder
                .ToTable("SocialAdres", "dbo");
        }
    }
}
