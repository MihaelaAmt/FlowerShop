using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    //create migration
    public partial class Order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //add column
            migrationBuilder.AddColumn<string>(
                //column name
                name: "SecurityCode",
                //table name
                table: "Orders",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //add column
            migrationBuilder.DropColumn(
                //column name
                name: "SecurityCode",
                //table name
                table: "Orders");
        }
    }
}
