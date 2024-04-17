using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManegmentSystem3.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    SoldQty = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    ItDate = table.Column<DateOnly>(type: "date", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItSale = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AttName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Dob = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserLevel = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
