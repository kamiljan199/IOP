using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class EmploeesAndStorePlacesSeeder : Migration
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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApartmentNumber", "City", "HomeNumber", "PostCode", "Street" },
                values: new object[,]
                {
                    { 1, 0, "Łuć", null, "98-205", "Skrzywana" },
                    { 2, 0, "Łuć", null, "98-205", "Radwańska" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "Login", "Name", "Password", "Pesel", "Surname" },
                values: new object[,]
                {
                    { 2, new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan84", "Jan", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "84110926511", "Drzewski" },
                    { 3, new DateTime(1965, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolskiMichelBay", "Patryk", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "6584421212", "Vege" },
                    { 4, new DateTime(2010, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EeeexD", "Ignacy", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "10040158425", "Luduba" },
                    { 5, new DateTime(1985, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tryglaw", "Czcibor", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "85101220686", "Piast" },
                    { 6, new DateTime(1995, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CoolSkeleton95", "Joanna", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "95050135841", "Sosna" },
                    { 7, new DateTime(1973, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "YourBestNightmare", "Janusz", "0DPiKuNIrrVmD8IUCuw1hQxNqZc=", "73021164841", "Tracz" }
                });

            migrationBuilder.InsertData(
                table: "Employments",
                columns: new[] { "Id", "EmployeeId", "EndDate", "IsActive", "PositionId", "Salary", "StartDate", "StorePlaceId" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 950f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 2800f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "StorePlaces",
                columns: new[] { "Id", "AddressId", "Discriminator", "Name", "ManagerName" },
                values: new object[] { 1, 1, "Warehouse", "Magazyn", "Tak" });

            migrationBuilder.InsertData(
                table: "StorePlaces",
                columns: new[] { "Id", "AddressId", "Discriminator", "Name", "WorkersCount" },
                values: new object[] { 2, 2, "SendingPoint", "Magazyn", 2 });

            migrationBuilder.InsertData(
                table: "Employments",
                columns: new[] { "Id", "EmployeeId", "EndDate", "IsActive", "PositionId", "Salary", "StartDate", "StorePlaceId" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 1600f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 1750f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 1300f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 1700f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

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
                name: "FK_RoutePoints_Parcels_ParcelId",
                table: "RoutePoints");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Employees_EmployeeId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Vehicles_VehicleId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_StorePlaces_Addresses_AddressId",
                table: "StorePlaces");

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StorePlaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StorePlaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "StorePlaces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
