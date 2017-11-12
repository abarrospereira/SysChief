using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using SysChief.Infra.Data.Context;
using System;

namespace SysChief.Infra.Data.Migrations
{
    [DbContext(typeof(SysChiefContext))]
    partial class SysChiefContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("SysChief.Domain.Models.Customer", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                b.Property<DateTime>("BirthDate");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(11);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100);

                b.HasKey("Id");

                b.ToTable("Customers");
            });
        }
    }
}
