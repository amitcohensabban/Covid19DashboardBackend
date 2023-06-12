using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Covid19Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class initModal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BedOccupancyTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralOccupancy = table.Column<double>(type: "float", nullable: true),
                    InternalMedicineOccupancy = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedOccupancyTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrafficLightsPlanTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<double>(type: "float", nullable: true),
                    NewPatients = table.Column<int>(type: "int", nullable: true),
                    PositivePatients = table.Column<int>(type: "int", nullable: true),
                    RateOfChange = table.Column<double>(type: "float", nullable: true),
                    ActivePatients = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficLightsPlanTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerifiedPatientsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnteringIsrael = table.Column<double>(type: "float", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedCitizens = table.Column<double>(type: "float", nullable: true),
                    VerifiedForeigners = table.Column<double>(type: "float", nullable: true),
                    VerifiedByTheIncoming = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifiedPatientsTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedOccupancyTable");

            migrationBuilder.DropTable(
                name: "TrafficLightsPlanTable");

            migrationBuilder.DropTable(
                name: "VerifiedPatientsTable");
        }
    }
}
