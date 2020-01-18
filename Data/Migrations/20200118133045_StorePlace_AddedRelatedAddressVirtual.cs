using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class StorePlace_AddedRelatedAddressVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorePlaces_Addresses_AddressId",
                table: "StorePlaces");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "StorePlaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StorePlaces_Addresses_AddressId",
                table: "StorePlaces",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorePlaces_Addresses_AddressId",
                table: "StorePlaces");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "StorePlaces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_StorePlaces_Addresses_AddressId",
                table: "StorePlaces",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
