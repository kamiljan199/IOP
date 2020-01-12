﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class HrRelationsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employments_ActiveEmploymentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Positions_PositionId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Employees_DriverId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_StorePlaces_WarehouseId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ActiveEmploymentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ActiveEmploymentId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Employments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employments_EmployeeId",
                table: "Employments",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Employees_EmployeeId",
                table: "Employments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Positions_PositionId",
                table: "Employments",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments",
                column: "WarehouseId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Employees_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_StorePlaces_WarehouseId",
                table: "Vehicles",
                column: "WarehouseId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Employees_EmployeeId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Positions_PositionId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Employees_DriverId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_StorePlaces_WarehouseId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Employments_EmployeeId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Employments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ActiveEmploymentId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ActiveEmploymentId",
                table: "Employees",
                column: "ActiveEmploymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employments_ActiveEmploymentId",
                table: "Employees",
                column: "ActiveEmploymentId",
                principalTable: "Employments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Positions_PositionId",
                table: "Employments",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_StorePlaces_WarehouseId",
                table: "Employments",
                column: "WarehouseId",
                principalTable: "StorePlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Employees_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Employees",
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
