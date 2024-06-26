﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using PrimeiraAppWeb_2TDSPF.Data;

#nullable disable

namespace PrimeiraAppWeb_2TDSPF.Migrations
{
    [DbContext(typeof(BoardgameDbContext))]
    [Migration("20240503130657_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrimeiraAppWeb_2TDSPF.Models.Boardgame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Boardgames");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Description = "Collect and trade resources to build up the island of Catan in this modern classic. ",
                            Name = "Catan"
                        },
                        new
                        {
                            Id = -2,
                            Description = "Shape the medieval landscape of France, claiming cities, monasteries and farms. ",
                            Name = "Carcassonne"
                        },
                        new
                        {
                            Id = -3,
                            Description = "Build your railroad across North America to connect cities and complete tickets. ",
                            Name = "Ticket to Ride"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
