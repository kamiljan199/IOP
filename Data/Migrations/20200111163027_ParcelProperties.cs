using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ParcelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ParcelHeight",
                table: "Parcels",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ParcelLength",
                table: "Parcels",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ParcelType",
                table: "Parcels",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ParcelWidth",
                table: "Parcels",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParcelHeight",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "ParcelLength",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "ParcelType",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "ParcelWidth",
                table: "Parcels");
        }
    }
}
