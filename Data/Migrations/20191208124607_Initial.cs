using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    PostCode = table.Column<string>(maxLength: 15, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    Number = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StorePlaceId = table.Column<int>(nullable: false),
                    SenderName = table.Column<string>(maxLength: 50, nullable: true),
                    SenderAddressId = table.Column<int>(nullable: true),
                    ReceiverName = table.Column<string>(maxLength: 50, nullable: true),
                    ReceiverAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_Address_ReceiverAddressId",
                        column: x => x.ReceiverAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Address_SenderAddressId",
                        column: x => x.SenderAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorePlace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    WorkersCount = table.Column<int>(nullable: true),
                    ManagerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorePlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorePlace_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ReceiverAddressId",
                table: "Packages",
                column: "ReceiverAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_SenderAddressId",
                table: "Packages",
                column: "SenderAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StorePlace_AddressId",
                table: "StorePlace",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "StorePlace");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
