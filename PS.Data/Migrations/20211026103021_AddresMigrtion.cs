using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class AddresMigrtion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Products",
                newName: "MyAddress_StreetAddress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "MyAddress_City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyAddress_StreetAddress",
                table: "Products",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "MyAddress_City",
                table: "Products",
                newName: "City");
        }
    }
}
