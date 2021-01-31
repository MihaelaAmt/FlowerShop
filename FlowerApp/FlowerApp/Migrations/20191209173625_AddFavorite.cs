using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    //migration for favorite flowers
    //name migration is AddFlower
    public partial class AddFavorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //add Column 
            migrationBuilder.AddColumn<bool>(
                //name 
                name: "IsFavorite",
                //table 
                table: "Flowers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                //name
                name: "IsFavorite",
                //table
                table: "Flowers");
        }
    }
}
