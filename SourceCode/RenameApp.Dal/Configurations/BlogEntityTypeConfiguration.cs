using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Blogs)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.BaseComment1)
                .WithMany(x => x.BaseComments)
                .HasForeignKey(x => x.BaseCommentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsUnicode(true);

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId");

            builder
                .Property(x => x.BaseComment)
                .HasColumnName("BaseComment")
                .IsUnicode(true);

            builder
                .Property(x => x.BaseCommentId)
                .HasColumnName("BaseCommentId");

            builder
                .Property(x => x.SubComent)
                .HasColumnName("SubComent")
                .IsUnicode(true);

            builder
                .ToTable("Blog", "dbo");
        }
    }
}
