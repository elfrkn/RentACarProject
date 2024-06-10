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
    [Migration("20240609111154_new2")]
    partial class new2
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

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentACar.DAL.DestinationLocation", b =>
                {
                    b.Property<int>("DestinationLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationLocationID"), 1L, 1);

                    b.Property<string>("DestinationLocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationLocationID");

                    b.ToTable("DestinationLocations");
                });

            modelBuilder.Entity("RentACar.DAL.ReceivingLocation", b =>
                {
                    b.Property<int>("ReceivingLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceivingLocationID"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceivingLocationID");

                    b.ToTable("ReceivingLocations");
                });

            modelBuilder.Entity("RentACar.DAL.RentACar", b =>
                {
                    b.Property<int>("RentACarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentACarID"), 1L, 1);

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("DestinationLocationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("PckUpDate")
                        .HasColumnType("Date");

                    b.Property<int>("ReceivingLocationID")
                        .HasColumnType("int");

                    b.HasKey("RentACarID");

                    b.HasIndex("CarID");

                    b.HasIndex("DestinationLocationID");

                    b.HasIndex("ReceivingLocationID");

                    b.ToTable("RentACars");
                });

            modelBuilder.Entity("RentACar.DAL.RentACar", b =>
                {
                    b.HasOne("RentACar.DAL.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACar.DAL.DestinationLocation", "DestinationLocation")
                        .WithMany("RentACars")
                        .HasForeignKey("DestinationLocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACar.DAL.ReceivingLocation", "ReceivingLocation")
                        .WithMany("RentACars")
                        .HasForeignKey("ReceivingLocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("DestinationLocation");

                    b.Navigation("ReceivingLocation");
                });

            modelBuilder.Entity("RentACar.DAL.DestinationLocation", b =>
                {
                    b.Navigation("RentACars");
                });

            modelBuilder.Entity("RentACar.DAL.ReceivingLocation", b =>
                {
                    b.Navigation("RentACars");
                });
#pragma warning restore 612, 618
        }
    }
}
