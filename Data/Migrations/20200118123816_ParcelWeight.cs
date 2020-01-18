using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ParcelWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ParcelWeight",
                table: "Parcels",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParcelWeight",
                table: "Parcels");
        }
    }
}
