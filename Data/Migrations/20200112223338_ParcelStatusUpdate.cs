using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ParcelStatusUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelivered",
                table: "Parcels");

            migrationBuilder.AddColumn<int>(
                name: "ParcelStatus",
                table: "Parcels",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParcelStatus",
                table: "Parcels");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelivered",
                table: "Parcels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
