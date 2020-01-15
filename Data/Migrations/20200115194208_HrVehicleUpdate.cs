using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class HrVehicleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "MaxCapacity",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MaxLoad",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0f);

            /*migrationBuilder.AddColumn<int>(
                name: "CourierID",
                table: "Parcels",
                nullable: true);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MaxLoad",
                table: "Vehicles");

            /*migrationBuilder.DropColumn(
                name: "CourierID",
                table: "Parcels");*/
        }
    }
}
