using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class HrSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_StorePlaces_StorePlaceId",
                table: "Employments");

            migrationBuilder.AlterColumn<int>(
                name: "StorePlaceId",
                table: "Employments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApartmentNumber", "City", "HomeNumber", "PostCode", "Street" },
                values: new object[,]
                {
                    { 2137, 420, "Wadowice", "JP2/GMD", "69-666", "Papieżowa" },
                    { 666, 666, "Piekło", "666/666", "66-666", "Ozzy'ego Osbourna" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "Login", "Name", "Password", "Pesel", "Surname" },
                values: new object[] { 1, new DateTime(1978, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "Mariusz", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "EZG 34XD23", "Pudzianowski" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "MaxSalary", "MinSalary", "Name" },
                values: new object[,]
                {
                    { 1, 25000f, 5000f, "Administrator" },
                    { 2, 1000f, 500f, "HR" },
                    { 3, 2000f, 1500f, "Kurier" },
                    { 4, 3000f, 2500f, "Logistyk" },
                    { 5, 1800f, 1500f, "Magazynier" },
                    { 6, 1800f, 1200f, "Rejestracja" }
                });

            migrationBuilder.InsertData(
                table: "Employments",
                columns: new[] { "Id", "EmployeeId", "EndDate", "IsActive", "PositionId", "Salary", "StartDate", "StorePlaceId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 20000f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_StorePlaceId",
                table: "Employments",
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

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "StorePlaceId",
                table: "Employments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_StorePlaceId",
                table: "Employments",
                column: "StorePlaceId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
