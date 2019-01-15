using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class updatedPurchaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerEmail",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BuyerName",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "PurchaseTableAccess",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerEmail",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "BuyerName",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "PurchaseTableAccess");
        }
    }
}
