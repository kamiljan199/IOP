using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class LogisticWarehouseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 4,
                column: "StorePlaceId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 4,
                column: "StorePlaceId",
                value: null);
        }
    }
}
