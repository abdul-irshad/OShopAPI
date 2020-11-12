using Microsoft.EntityFrameworkCore.Migrations;

namespace OShopAPI.Migrations
{
    public partial class UpdateProductCategoryColoummType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}