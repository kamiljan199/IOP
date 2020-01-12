using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class HrEmploymentFKUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employments_ActiveEmploymentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ActiveEmploymentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ActiveEmploymentId",
                table: "Employees");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Employees_EmployeeId",
                table: "Employments");

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
        }
    }
}
