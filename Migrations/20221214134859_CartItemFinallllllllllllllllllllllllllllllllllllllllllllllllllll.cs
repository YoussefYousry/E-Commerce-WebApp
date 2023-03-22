using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinallllllllllllllllllllllllllllllllllllllllllllllllllll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_carts_cartId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24ef4801-428a-4fc3-9190-3a0d494cbfb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf7d5e76-3520-4a81-b0cc-8ae3b6370910");

            migrationBuilder.DropColumn(
                name: "CartIdFK",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "cartId",
                table: "CartItems",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_cartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "439ff06c-4519-4e73-8a05-0c0ee1e3dc13", "26d15c64-4f3d-46d8-8810-c32eaed8676f", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd05b8e9-77de-423c-8ce8-cb174d51a4f8", "1553efb5-36b2-4424-b9ce-d32680b9fb03", "User", "User" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_carts_CartId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "439ff06c-4519-4e73-8a05-0c0ee1e3dc13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd05b8e9-77de-423c-8ce8-cb174d51a4f8");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartItems",
                newName: "cartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                newName: "IX_CartItems_cartId");

            migrationBuilder.AlterColumn<int>(
                name: "cartId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartIdFK",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24ef4801-428a-4fc3-9190-3a0d494cbfb4", "c48599fb-36bf-44c4-893b-1faf8861e513", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf7d5e76-3520-4a81-b0cc-8ae3b6370910", "1272ff39-9270-4e74-ae32-9cd05bfe3c0e", "Admin", "Admin" });

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
