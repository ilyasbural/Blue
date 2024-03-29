﻿// <auto-generated />
using System;
using Blue.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blue.DataAccess.Migrations
{
    [DbContext(typeof(BlueContext))]
    [Migration("20231222205439_werwerwer")]
    partial class werwerwer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blue.Core.BuildingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("BuildingType", (string)null);
                });

            modelBuilder.Entity("Blue.Core.BuyingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("BuyingType", (string)null);
                });

            modelBuilder.Entity("Blue.Core.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("Blue.Core.District", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("District", (string)null);
                });

            modelBuilder.Entity("Blue.Core.FeaturesAround", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("FeaturesAround", (string)null);
                });

            modelBuilder.Entity("Blue.Core.FeaturesInside", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("FeaturesInside", (string)null);
                });

            modelBuilder.Entity("Blue.Core.FeaturesOutside", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("FeaturesOutside", (string)null);
                });

            modelBuilder.Entity("Blue.Core.FromWho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("FromWho", (string)null);
                });

            modelBuilder.Entity("Blue.Core.FuelType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("FuelType", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Furniture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Furniture", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Hometown", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Hometown", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Management", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Management", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Picture", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Price", (string)null);
                });

            modelBuilder.Entity("Blue.Core.RealEstate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuyingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("BuildingTypeId");

                    b.HasIndex("BuyingTypeId");

                    b.ToTable("RealEstate", (string)null);
                });

            modelBuilder.Entity("Blue.Core.RealEstateDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("RealEstateDetail", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Room", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Type", (string)null);
                });

            modelBuilder.Entity("Blue.Core.Warming", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Warming", (string)null);
                });

            modelBuilder.Entity("Blue.Core.RealEstate", b =>
                {
                    b.HasOne("Blue.Core.BuildingType", "BuildingType")
                        .WithMany()
                        .HasForeignKey("BuildingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blue.Core.BuyingType", "BuyingType")
                        .WithMany()
                        .HasForeignKey("BuyingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuildingType");

                    b.Navigation("BuyingType");
                });
#pragma warning restore 612, 618
        }
    }
}
