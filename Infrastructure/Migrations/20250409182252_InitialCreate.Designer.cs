﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20250409182252_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned")
                        .HasColumnName("productID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<uint>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name")
                        .HasDefaultValueSql("''");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)")
                        .HasColumnName("price")
                        .HasDefaultValueSql("'99999.99'");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)")
                        .HasColumnName("productCode")
                        .HasDefaultValueSql("''")
                        .IsFixedLength();

                    b.Property<uint>("Quantity")
                        .HasColumnType("int unsigned")
                        .HasColumnName("quantity");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("products", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
