using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class categoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MyCategorie",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "MyCategorie",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");
        }
    }
}
