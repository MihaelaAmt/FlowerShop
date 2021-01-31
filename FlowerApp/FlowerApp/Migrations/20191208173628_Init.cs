using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FlowerApp.Migrations
{
    //create migration
    public partial class Init : Migration
    {
        //create const for
        //AspNetRoles
        private const string AspNetRoles = "AspNetRoles";
        //AspNetUsers
        private const string AspNetUsers = "AspNetUsers";
        //Value Generation Strategy
        private const string ValueGenerationStrategy = "SqlServer:ValueGenerationStrategy";
        //Flowers
        private const string Flowers = "Flowers";
        //OrderDetails
        private const string OrderDetails = "OrderDetails";
        //Flower Id
        private const string Flower_Id = "FlowerId";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //create table
            migrationBuilder.CreateTable(
                //table name
                name: AspNetRoles,
                //create columns
                columns: table => new
                {
                    //column for Id
                    Id = table.Column<string>(nullable: false),
                    //column for name
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    //column fr normalized name
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    //column dor concurrency stamp
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create the primary Key
                    //primary key for this table is Id
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            //create table
            migrationBuilder.CreateTable(
                //table name
                name: AspNetRoles,
                //create columns
                columns: table => new
                {
                    //column for id
                    Id = table.Column<string>(nullable: false),
                    //column for username
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    //column for normalized user name
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    //column for email
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    //column for normlaized email
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    //column for email confirmed
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    //column for password hash
                    PasswordHash = table.Column<string>(nullable: true),
                    //column for security Stamp
                    SecurityStamp = table.Column<string>(nullable: true),
                    //column for concurrency stamp
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    //column for phone number
                    PhoneNumber = table.Column<string>(nullable: true),
                    //column for phhone numbe confirmed
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    //column for two factor enabled
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    //column for lockoutend
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    //column for lockout enabled
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    //column for acces failed count
                    AccessFailedCount = table.Column<int>(nullable: false),
                    //column for birthdate
                    Birthdate = table.Column<DateTime>(nullable: false),
                    //column for city
                    City = table.Column<string>(nullable: true),
                    //column for country
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create primary key
                    //the primary key for this table is Id
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "Categories",
                //create columns
                columns: table => new
                {
                    //column for category Id
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    //column for category name
                    CategoryName = table.Column<string>(nullable: true),
                    //column for description
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create primary key
                    //the primary key for this table is Category Id
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "Orders",
                //create columns
                columns: table => new
                {
                    //column for Order Id
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    //column for first name
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    //column for last name
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    //column for address
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    //column for zip code
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    //column for city
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    //column for state
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    //column for country
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    //column for phone number
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    // column for email
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    //column for order total
                    OrderTotal = table.Column<decimal>(nullable: false),
                    //column for order placed
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    //create primary key
                    //the primary key for this table is Order Id
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "AspNetRoleClaims",
                //create columns
                columns: table => new
                {
                    //column for id
                    Id = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    //column for role Id
                    RoleId = table.Column<string>(nullable: false),
                    //column for claim Type
                    ClaimType = table.Column<string>(nullable: true),
                    //column for Value
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create primary key
                    //the primary key is Id
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    //create foreign key
                    //the foreign key is Role Id from AspNetRoles table
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: AspNetRoles,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "AspNetUserClaims",
                //create columns
                columns: table => new
                {
                    //column for id
                    Id = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    //column for user id
                    UserId = table.Column<string>(nullable: false),
                    //column for Claim Type
                    ClaimType = table.Column<string>(nullable: true),
                    //column fir claim Value
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create primary key
                    //the primary key is Id
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    //the foreign key is user id from AspNetUsers table
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: AspNetUsers,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "AspNetUserLogins",
                //create columns
                columns: table => new
                {
                    //column for login provider
                    LoginProvider = table.Column<string>(nullable: false),
                    //column for provider key
                    ProviderKey = table.Column<string>(nullable: false),
                    //column for provider display name
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    //column for user id
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    //create primary key
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    //the foreign key is user id from AspNetUser table
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: AspNetUsers,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "AspNetUserRoles",
                //create columns
                columns: table => new
                {
                    //column for UserId
                    UserId = table.Column<string>(nullable: false),
                    //column for RoleId
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    //primary key
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    //foreign key
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: AspNetRoles,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: AspNetUsers,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            //create table
            migrationBuilder.CreateTable(
                //table name
                name: "AspNetUserTokens",
                //create columns
                columns: table => new
                {
                    //column for user id
                    UserId = table.Column<string>(nullable: false),
                    //column for login provider
                    LoginProvider = table.Column<string>(nullable: false),
                    //column for name
                    Name = table.Column<string>(nullable: false),
                    //column for value
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //create primary key
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    //create foreign key
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: AspNetUsers,
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: Flowers,
                columns: table => new
                {
                    FlowerId = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    IsFlowerPresentation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.FlowerId);
                    table.ForeignKey(
                        name: "FK_Flowers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: OrderDetails,
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: Flowers,
                        principalColumn: "FlowerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation(ValueGenerationStrategy, SqlServerValueGenerationStrategy.IdentityColumn),
                    FlowerId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: Flowers,
                        principalColumn: Flower_Id,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: AspNetRoles,
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: AspNetUsers,
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: AspNetUsers,
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_CategoryId",
                table: Flowers,
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_FlowerId",
                table: OrderDetails,
                column: Flower_Id);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: OrderDetails,
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_FlowerId",
                table: "ShoppingCartItems",
                column: Flower_Id);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: OrderDetails);

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: AspNetRoles);

            migrationBuilder.DropTable(
                name: AspNetUsers);

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: Flowers);

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
