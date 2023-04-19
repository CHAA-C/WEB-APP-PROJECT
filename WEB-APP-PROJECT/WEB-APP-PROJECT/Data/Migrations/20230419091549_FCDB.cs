using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_APP_PROJECT.Data.Migrations
{
    public partial class FCDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCourtSS");

            migrationBuilder.CreateTable(
                name: "FoodCourts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodRecommened = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiderCount = table.Column<int>(type: "int", nullable: true),
                    FoodShopImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCourts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCourts");

            migrationBuilder.CreateTable(
                name: "FoodCourtSS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodRecommened = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodShopImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiderCount = table.Column<int>(type: "int", nullable: true),
                    ShopContact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCourtSS", x => x.Id);
                });
        }
    }
}
