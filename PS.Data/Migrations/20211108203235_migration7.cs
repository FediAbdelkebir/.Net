using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "MyCategories",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "IsBiological",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBiological",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MyCategories",
                newName: "MyName");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
