using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class propertiesfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "PaintingTableAccess");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "PaintingTableAccess",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PaintingTableAccess",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "PaintingTableAccess",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PriceRange",
                table: "PaintingTableAccess",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "PaintingTableAccess",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "PaintingTableAccess");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PaintingTableAccess");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "PaintingTableAccess");

            migrationBuilder.DropColumn(
                name: "PriceRange",
                table: "PaintingTableAccess");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "PaintingTableAccess");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PaintingTableAccess",
                nullable: false,
                defaultValue: "");
        }
    }
}
