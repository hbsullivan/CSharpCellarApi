﻿// <auto-generated />
using CellarApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CellarApi.Migrations
{
    [DbContext(typeof(CellarApiContext))]
    [Migration("20230303161543_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CellarApi.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Appellation")
                        .HasColumnType("longtext");

                    b.Property<string>("Climate")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Soil")
                        .HasColumnType("longtext");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            RegionId = 1,
                            Appellation = "Dundee Hills AVA",
                            Climate = "Cool",
                            Country = "USA",
                            Soil = "Jory"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
