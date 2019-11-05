using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    public partial class AddShoppingCartItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFlowerPresentation",
                table: "Flowers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFlowerPresentation",
                table: "Flowers");
        }
    }
}
