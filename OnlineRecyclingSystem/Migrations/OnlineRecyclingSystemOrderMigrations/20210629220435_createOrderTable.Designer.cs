﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineRecyclingSystem.Data;

namespace OnlineRecyclingSystem.Migrations.OnlineRecyclingSystemOrderMigrations
{
    [DbContext(typeof(OnlineRecyclingSystemOrder))]
    [Migration("20210629220435_createOrderTable")]
    partial class createOrderTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineRecyclingSystem.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigBottle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Can")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallBottle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}