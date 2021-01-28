using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    public partial class ShippingAndPaymentMethods : Migration
    {
        private const string Orders = "Orders";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: Orders,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayMethod",
                table: Orders,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShippingMethod",
                table: Orders,
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: Orders);

            migrationBuilder.DropColumn(
                name: "PayMethod",
                table: Orders);

            migrationBuilder.DropColumn(
                name: "ShippingMethod",
                table: Orders);
        }
    }
}
