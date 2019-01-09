using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class addedVirtualToPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaintingEntityId",
                table: "PurchaseTableAccess",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseTableAccess_PaintingEntityId",
                table: "PurchaseTableAccess",
                column: "PaintingEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseTableAccess_PaintingTableAccess_PaintingEntityId",
                table: "PurchaseTableAccess",
                column: "PaintingEntityId",
                principalTable: "PaintingTableAccess",
                principalColumn: "PaintingEntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseTableAccess_PaintingTableAccess_PaintingEntityId",
                table: "PurchaseTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseTableAccess_PaintingEntityId",
                table: "PurchaseTableAccess");

            migrationBuilder.DropColumn(
                name: "PaintingEntityId",
                table: "PurchaseTableAccess");
        }
    }
}
