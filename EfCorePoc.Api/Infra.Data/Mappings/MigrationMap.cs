using EfCorePoc.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EfCorePoc.Api.Infra.Data.Mappings
{
    public class MigrationMap : IEntityTypeConfiguration<Migration>
    {
        public void Configure(EntityTypeBuilder<Migration> builder)
        {
            builder
                .ToTable("Migrations")
                .HasKey(m => m.MigrationId);

            builder
                .Property(m => m.StartedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.Observations)
                .HasMaxLength(255)
                .HasColumnType("varchar"); //It's important if you are use varchar in your database
            //see: https://blog.kylegalbraith.com/2019/05/15/the-curious-case-of-nvarchar-and-varchar-in-entity-framework/

            builder.HasIndex(m => m.StartedAt);
        }
    }
}
