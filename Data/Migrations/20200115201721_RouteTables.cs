using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RouteTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: true),
                    VehicleId = table.Column<int>(nullable: true),
                    CreationDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoutePoints",
                columns: table => new
                {
                    RouteId = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    ParcelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutePoints", x => new { x.RouteId, x.Index });
                    table.ForeignKey(
                        name: "FK_RoutePoints_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoutePoints_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_ParcelId",
                table: "RoutePoints",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_RouteId",
                table: "RoutePoints",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EmployeeId",
                table: "Routes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_VehicleId",
                table: "Routes",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoutePoints");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
