﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.DAL;

#nullable disable

namespace RentACar.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240607222658_mog1")]
    partial class mog1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentACar.DAL.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarID"), 1L, 1);

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarGearType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarKM")
                        .HasColumnType("int");

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorPower")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentACar.DAL.RentACar", b =>
                {
                    b.Property<int>("RentACarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentACarID"), 1L, 1);

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarBrand")
                        .HasColumnType("int");

                    b.Property<int>("CarModel")
                        .HasColumnType("int");

                    b.Property<string>("DestinationLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("Date");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyProperty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PckUpDate")
                        .HasColumnType("Date");

                    b.Property<string>("ReceivingLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentACarID");

                    b.ToTable("RentACars");
                });
#pragma warning restore 612, 618
        }
    }
}
