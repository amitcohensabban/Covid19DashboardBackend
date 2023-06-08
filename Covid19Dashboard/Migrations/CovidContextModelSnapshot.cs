﻿// <auto-generated />
using System;
using Covid19Dashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Covid19Dashboard.Migrations
{
    [DbContext(typeof(CovidContext))]
    partial class CovidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Covid19Dashboard.Models.BedOccupancy", b =>
                {
                    b.Property<double?>("GeneralOccupancy")
                        .HasColumnType("float");

                    b.Property<string>("HospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("InternalMedicineOccupancy")
                        .HasColumnType("float");

                    b.ToTable("BedOccupancyTable");
                });

            modelBuilder.Entity("Covid19Dashboard.Models.TrafficLightsPlan", b =>
                {
                    b.Property<int?>("ActivePatients")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Grade")
                        .HasColumnType("float");

                    b.Property<int?>("NewPatients")
                        .HasColumnType("int");

                    b.Property<int?>("PositivePatients")
                        .HasColumnType("int");

                    b.Property<double?>("RateOfChange")
                        .HasColumnType("float");

                    b.ToTable("TrafficLightsPlanTable");
                });

            modelBuilder.Entity("Covid19Dashboard.Models.VerifiedPatients", b =>
                {
                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("EnteringIsrael")
                        .HasColumnType("float");

                    b.Property<int?>("LastMonth")
                        .HasColumnType("int");

                    b.Property<int?>("SixMonth")
                        .HasColumnType("int");

                    b.Property<int?>("ThreeMonth")
                        .HasColumnType("int");

                    b.Property<int?>("UntillNow")
                        .HasColumnType("int");

                    b.Property<double?>("VerifiedByTheIncoming")
                        .HasColumnType("float");

                    b.Property<double?>("VerifiedCitizens")
                        .HasColumnType("float");

                    b.Property<double?>("VerifiedForeigners")
                        .HasColumnType("float");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.ToTable("VerifiedPatientsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
