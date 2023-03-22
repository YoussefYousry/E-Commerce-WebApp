using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinalllllllll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a64884-05cd-44b0-b2bf-9b4bcd24537e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61311d71-a285-4dbd-a2a6-c6ba55c68e08");

            migrationBuilder.AddColumn<int>(
                name: "cartId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28f37299-7134-440e-a003-23f7154309f3", "089ed8c9-4723-4336-b19f-c0cd5a4e57eb", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a9173ec-93ad-4086-9137-7d7c596591e4", "c54a5f67-4aee-4717-9bee-a1ec1cc6bb1f", "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_cartId",
                table: "CartItems",
                column: "cartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_carts_cartId",
                table: "CartItems",
                column: "cartId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_carts_cartId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_cartId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28f37299-7134-440e-a003-23f7154309f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a9173ec-93ad-4086-9137-7d7c596591e4");

            migrationBuilder.DropColumn(
                name: "cartId",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46a64884-05cd-44b0-b2bf-9b4bcd24537e", "7c8d5f89-f010-420e-92a8-aefe118897f1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61311d71-a285-4dbd-a2a6-c6ba55c68e08", "3557f552-ef3a-4918-b154-ab392d3981f8", "User", "User" });
        }
    }
}
