﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Momentum.Migrations
{
    [DbContext(typeof(MomentumDbContext))]
    [Migration("20250312055159_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvgHr")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<TimeOnly>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("Pace")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Workout");
                });
#pragma warning restore 612, 618
        }
    }
}
