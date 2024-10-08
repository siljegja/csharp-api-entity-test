﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240909094344_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("booking");

                    b.HasKey("DoctorId", "PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            PatientId = 1,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1512)
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 2,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1514)
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 3,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1515)
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 4,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1516)
                        },
                        new
                        {
                            DoctorId = 1,
                            PatientId = 4,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1517)
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 3,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1518)
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 2,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1518)
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 1,
                            Booking = new DateTime(2024, 9, 9, 9, 43, 44, 201, DateTimeKind.Utc).AddTicks(1519)
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jane Doe"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "John Smith"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Jane Smith"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Anna Drijver"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Tom Cruise"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Gerogina Verbaan"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Daan Schuurmans"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
