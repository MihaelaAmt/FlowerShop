using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerApp.Migrations
{
    //create migration
    public partial class ShippingAndPaymentMethods1 : Migration
    {
        //create const for orders
        private const string Orders = "Orders";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //add column
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "ZipCode",
                //table name
                table: Orders,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);
            //create column
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "Country",
                //table name
                table: Orders,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
            //create column
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "AddressLine1",
                //table name
                table: Orders,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //create column
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "ZipCode",
                //table name
                table: Orders,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
            //create column 
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "Country",
                //table name
                table: Orders,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
            //create column
            migrationBuilder.AlterColumn<string>(
                //column name
                name: "AddressLine1",
                //table name
                table: Orders,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
