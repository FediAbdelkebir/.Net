using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class Chemical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.AlterColumn<string>(
                name: "MyName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    CIN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    ClientFK = table.Column<int>(type: "int", nullable: false),
                    ProductFk = table.Column<int>(type: "int", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    ProductFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => new { x.ClientFK, x.ProductFk, x.DateAchat });
                    table.ForeignKey(
                        name: "FK_Factures_Clients_ClientFK",
                        column: x => x.ClientFK,
                        principalTable: "Clients",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factures_Products_ProductFk",
                        column: x => x.ProductFk,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factures_ProductFk",
                table: "Factures",
                column: "ProductFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
