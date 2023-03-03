﻿// <auto-generated />
using CellarApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CellarApi.Migrations
{
    [DbContext(typeof(CellarApiContext))]
    partial class CellarApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            RegionId = 2,
                            Appellation = "Champage AOC",
                            Climate = "Cool",
                            Country = "France",
                            Soil = "Chalk"
                        },
                        new
                        {
                            RegionId = 3,
                            Appellation = "Chablis AOC",
                            Climate = "Cool",
                            Country = "France",
                            Soil = "Limestone"
                        },
                        new
                        {
                            RegionId = 4,
                            Appellation = "Rioja DOCa",
                            Climate = "Warm",
                            Country = "Spain",
                            Soil = "Alluvial"
                        },
                        new
                        {
                            RegionId = 5,
                            Appellation = "Chianti DOCG",
                            Climate = "Warm",
                            Country = "Italy",
                            Soil = "Galestro"
                        },
                        new
                        {
                            RegionId = 6,
                            Appellation = "Barossa Valley",
                            Climate = "Warm",
                            Country = "Australia",
                            Soil = "Sandy Clay"
                        },
                        new
                        {
                            RegionId = 7,
                            Appellation = "Marlborough",
                            Climate = "Cool",
                            Country = "New Zealand",
                            Soil = "Alluvial"
                        },
                        new
                        {
                            RegionId = 8,
                            Appellation = "Barolo DOCG",
                            Climate = "Cool",
                            Country = "Italy",
                            Soil = "Clay"
                        },
                        new
                        {
                            RegionId = 9,
                            Appellation = "Bourgogne AOC",
                            Climate = "Cool",
                            Country = "France",
                            Soil = "Clay"
                        },
                        new
                        {
                            RegionId = 10,
                            Appellation = "Muscadet AOC",
                            Climate = "Cool",
                            Country = "France",
                            Soil = "Gneiss"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
