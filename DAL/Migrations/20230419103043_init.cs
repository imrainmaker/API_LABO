using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetNbr = table.Column<int>(type: "int", nullable: false),
                    StreetBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.CheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SellerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_products_users_SellerUserId",
                        column: x => x.SellerUserId,
                        principalTable: "users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerUserId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_invoices_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_invoices_users_BuyerUserId",
                        column: x => x.BuyerUserId,
                        principalTable: "users",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "City", "Country", "Email", "Firstname", "Lastname", "Password", "Phone", "Role", "Street", "StreetBox", "StreetNbr", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Brussels", "Belgium", "jeremy.bazin@email.com", "Jeremy", "Bazin", "Test123=", "+32 2 123 45 67", 0, "Rue de la Paix", null, 10, "1000" },
                    { 2, "New York", "USA", "bob.martin@email.com", "Bob", "Martin", "5Gh#zBvKw3PxYrE", "+1 123-456-7890", 2, "Main Street", null, 25, "12345" },
                    { 3, "Los Angeles", "USA", "charlie.nguyen@email.com", "Charlie", "Nguyen", "fT7#eRm2QxLz9Dy$", "+1 234-567-8901", 1, "Highway Road", null, 50, "67890" },
                    { 4, "London", "UK", "david.lee@email.com", "David", "Lee", "V6b$UwPcNz @hM8xK", "+44 20 1234 5678", 2, "Oxford Street", null, 15, "W1D 1BS" },
                    { 5, "Barcelona", "Spain", "emma.garcia@email.com", "Emma", "Garcia", "aH5%kXjL9$qBm2W", "+34 93 123 45 67", 1, "Carrer de Balmes", null, 12, "08007" },
                    { 6, "Shanghai", "China", "frank.chen@email.com", "Frank", "Chen", "qJ9@fM8cWu5$xLrE", "+86 21 1234 5678", 2, "Nanjing Road", null, 100, "200000" },
                    { 7, "Brussels", "Belgium", "grace.wong@email.com", "Grace", "Wong", "7Km&zRb#vGy2hNj", "555-1234", 2, "3 Main St", null, 35, "1000" },
                    { 8, "Brussels", "Belgium", "henry.zhang@email.com", "Henry", "Zhang", "T4c#nSv@wGj2RkF", "555-1234", 1, "9 High St", null, 45, "1000" },
                    { 9, "Brussels", "Belgium", "isabella.lopez@email.com", "Isabella", "Lopez", "H8f$kL3q#sVp9Xy", "555-1234", 1, "12 Park Ave", null, 24, "1000" },
                    { 10, "Brussels", "Belgium", "jack.kim@email.com", "Jack", "Kim", "3ZgY*6tLx#pVfDhN", "555-1234", 2, "15 Rue de la Loi", null, 4, "1000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_invoices_BuyerUserId",
                table: "invoices",
                column: "BuyerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_ProductId",
                table: "invoices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_SellerUserId",
                table: "products",
                column: "SellerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
