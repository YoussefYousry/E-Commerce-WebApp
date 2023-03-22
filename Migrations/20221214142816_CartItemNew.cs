using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_carts_cartId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");





            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItemsTable");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_cartId",
                table: "CartItemsTable",
                newName: "IX_CartItemsTable_cartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItemsTable",
                table: "CartItemsTable",
                column: "Id");



            migrationBuilder.AddForeignKey(
                name: "FK_CartItemsTable_carts_cartId",
                table: "CartItemsTable",
                column: "cartId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemsTable_carts_cartId",
                table: "CartItemsTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItemsTable",
                table: "CartItemsTable");



            migrationBuilder.RenameTable(
                name: "CartItemsTable",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_CartItemsTable_cartId",
                table: "CartItems",
                newName: "IX_CartItems_cartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

 

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_carts_cartId",
                table: "CartItems",
                column: "cartId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
