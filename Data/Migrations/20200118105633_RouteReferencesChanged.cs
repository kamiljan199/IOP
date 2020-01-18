using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RouteReferencesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutePoints_Parcels_ParcelId",
                table: "RoutePoints");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Employees_EmployeeId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Vehicles_VehicleId",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Routes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Routes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParcelId",
                table: "RoutePoints",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutePoints_Parcels_ParcelId",
                table: "RoutePoints",
                column: "ParcelId",
                principalTable: "Parcels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Employees_EmployeeId",
                table: "Routes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Vehicles_VehicleId",
                table: "Routes",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutePoints_Parcels_ParcelId",
                table: "RoutePoints");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Employees_EmployeeId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Vehicles_VehicleId",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ParcelId",
                table: "RoutePoints",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_RoutePoints_Parcels_ParcelId",
                table: "RoutePoints",
                column: "ParcelId",
                principalTable: "Parcels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Employees_EmployeeId",
                table: "Routes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Vehicles_VehicleId",
                table: "Routes",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
