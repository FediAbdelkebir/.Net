using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MyCategories",
                newName: "MyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "MyCategories",
                newName: "Name");
        }
    }
}
