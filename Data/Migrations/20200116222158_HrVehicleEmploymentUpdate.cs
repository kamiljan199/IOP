using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class HrVehicleEmploymentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_StorePlaces_WarehouseId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_WarehouseId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Employments_WarehouseId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Employments");

            migrationBuilder.AddColumn<int>(
                name: "StorePlaceId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StorePlaceId",
                table: "Employments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_StorePlaceId",
                table: "Vehicles",
                column: "StorePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employments_StorePlaceId",
                table: "Employments",
                column: "StorePlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_StorePlaceId",
                table: "Employments",
                column: "StorePlaceId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_StorePlaces_StorePlaceId",
                table: "Vehicles",
                column: "StorePlaceId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_StorePlaces_StorePlaceId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_StorePlaces_StorePlaceId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_StorePlaceId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Employments_StorePlaceId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "StorePlaceId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "StorePlaceId",
                table: "Employments");

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Employments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_WarehouseId",
                table: "Vehicles",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Employments_WarehouseId",
                table: "Employments",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments",
                column: "WarehouseId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_StorePlaces_WarehouseId",
                table: "Vehicles",
                column: "WarehouseId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
