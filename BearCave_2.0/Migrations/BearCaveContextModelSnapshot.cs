﻿// <auto-generated />
using System;
using BearCave_2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BearCave_2._0.Migrations
{
    [DbContext(typeof(BearCaveContext))]
    partial class BearCaveContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BearCave_2._0.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HBref")
                        .HasColumnType("int");

                    b.Property<int>("HomePhone")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobilePhone")
                        .HasColumnType("int");

                    b.Property<string>("NINumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RentPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TenancyStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkPhone")
                        .HasColumnType("int");

                    b.Property<double>("YTDBalance")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BearCave_2._0.Models.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyID");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("BearCave_2._0.Models.Unit", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<float>("CurrentRent")
                        .HasColumnType("real");

                    b.Property<float>("DefaultRent")
                        .HasColumnType("real");

                    b.Property<int>("DoorNum")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("UnitID");

                    b.HasIndex("ClientID");

                    b.HasIndex("PropertyID");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("BearCave_2._0.Models.Unit", b =>
                {
                    b.HasOne("BearCave_2._0.Models.Client", null)
                        .WithMany("Units")
                        .HasForeignKey("ClientID");

                    b.HasOne("BearCave_2._0.Models.Property", null)
                        .WithMany("Units")
                        .HasForeignKey("PropertyID");
                });
#pragma warning restore 612, 618
        }
    }
}
