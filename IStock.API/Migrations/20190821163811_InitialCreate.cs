using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IStock.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cid = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ProCost = table.Column<double>(nullable: false),
                    ProSell = table.Column<double>(nullable: false),
                    SupId = table.Column<int>(nullable: false),
                    GlobalId = table.Column<int>(nullable: false),
                    MinInStock = table.Column<int>(nullable: false),
                    TotalInStock = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
