﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using practice.Models;

#nullable disable

namespace practice.Migrations
{
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Cyrillic_General_CI_AS")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("practice.Models.Material", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<int?>("ItemsInPackage")
                        .HasColumnType("int")
                        .HasColumnName("itemsInPackage");

                    b.Property<int>("MinCount")
                        .HasColumnType("int")
                        .HasColumnName("minCount");

                    b.Property<string>("Picture")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("picture");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.Property<string>("Unit")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("unit");

                    b.HasKey("Name");

                    b.ToTable("material", (string)null);
                });

            modelBuilder.Entity("practice.Models.Materialsupplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("material");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("supplier");

                    b.HasKey("Id");

                    b.HasIndex("Material");

                    b.HasIndex("Supplier");

                    b.ToTable("materialsupplier", (string)null);
                });

            modelBuilder.Entity("practice.Models.Supplier", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<string>("Tin")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("TIN");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.Property<DateOnly>("WorkSince")
                        .HasColumnType("date")
                        .HasColumnName("workSince");

                    b.HasKey("Name")
                        .HasName("PK_supplier_1");

                    b.ToTable("supplier", (string)null);
                });

            modelBuilder.Entity("practice.Models.Materialsupplier", b =>
                {
                    b.HasOne("practice.Models.Material", "MaterialNavigation")
                        .WithMany("Materialsuppliers")
                        .HasForeignKey("Material")
                        .IsRequired()
                        .HasConstraintName("FK_materialsupplier_material");

                    b.HasOne("practice.Models.Supplier", "SupplierNavigation")
                        .WithMany("Materialsuppliers")
                        .HasForeignKey("Supplier")
                        .IsRequired()
                        .HasConstraintName("FK_materialsupplier_supplier");

                    b.Navigation("MaterialNavigation");

                    b.Navigation("SupplierNavigation");
                });

            modelBuilder.Entity("practice.Models.Material", b =>
                {
                    b.Navigation("Materialsuppliers");
                });

            modelBuilder.Entity("practice.Models.Supplier", b =>
                {
                    b.Navigation("Materialsuppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
