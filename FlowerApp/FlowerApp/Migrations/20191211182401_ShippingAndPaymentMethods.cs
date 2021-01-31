using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    //create migration
    //migration name is Shipping and payment methods
    public partial class ShippingAndPaymentMethods : Migration
    {
        private const string Orders = "Orders";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //add column
            migrationBuilder.AddColumn<string>(
                //first column is for card
                name: "CardNumber",
                //table name is  Orders
                table: Orders,
                //set length
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                //column name is pay method
                name: "PayMethod",
                table: Orders,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                //column name is pay method
                name: "ShippingMethod",
                table: Orders,
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                //in drop menu, column name is card number
                name: "CardNumber",
                table: Orders);

            migrationBuilder.DropColumn(
                //in drop menu, column name is pay method
                name: "PayMethod",
                table: Orders);

            migrationBuilder.DropColumn(
                //in drop menu, column name is pay method
                name: "ShippingMethod",
                table: Orders);
        }
    }
}
