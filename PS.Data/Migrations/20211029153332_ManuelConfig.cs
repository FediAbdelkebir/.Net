using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class ManuelConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_MyProdsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Provider_MyProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providing");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "MyCategorie");

            migrationBuilder.RenameColumn(
                name: "MyAddress_StreetAddress",
                table: "Products",
                newName: "MyAddress");

            migrationBuilder.RenameColumn(
                name: "MyAddress_City",
                table: "Products",
                newName: "MyCity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_MyProvidersId",
                table: "Providing",
                newName: "IX_Providing_MyProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "MyAddress",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyCategorie",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providing",
                table: "Providing",
                columns: new[] { "MyProdsProductId", "MyProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategorie",
                table: "MyCategorie",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MyCategorie_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "MyCategorie",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providing_Products_MyProdsProductId",
                table: "Providing",
                column: "MyProdsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providing_Provider_MyProvidersId",
                table: "Providing",
                column: "MyProvidersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MyCategorie_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providing_Products_MyProdsProductId",
                table: "Providing");

            migrationBuilder.DropForeignKey(
                name: "FK_Providing_Provider_MyProvidersId",
                table: "Providing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providing",
                table: "Providing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategorie",
                table: "MyCategorie");

            migrationBuilder.RenameTable(
                name: "Providing",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategorie",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "Products",
                newName: "MyAddress_City");

            migrationBuilder.RenameColumn(
                name: "MyAddress",
                table: "Products",
                newName: "MyAddress_StreetAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Providing_MyProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_MyProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "MyAddress_StreetAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "MyProdsProductId", "MyProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_MyProdsProductId",
                table: "ProductProvider",
                column: "MyProdsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Provider_MyProvidersId",
                table: "ProductProvider",
                column: "MyProvidersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
