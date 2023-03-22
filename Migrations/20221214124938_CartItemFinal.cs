using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c91ed08-eaff-4c14-b7d2-64dbe190fe1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99688627-a019-4f6c-9a1e-5466526f4c0a");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c8008c7-f53d-42f6-a8a9-9f7185d4cf4f", "d34cd5ef-9200-420d-8cb3-ec7c2e68129e", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d012b5ae-b185-4d0c-a62c-175559aed50d", "3caf893f-2fd5-404a-a650-fa2e7bd8b122", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c8008c7-f53d-42f6-a8a9-9f7185d4cf4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d012b5ae-b185-4d0c-a62c-175559aed50d");

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
                values: new object[] { "3c91ed08-eaff-4c14-b7d2-64dbe190fe1c", "60557105-63ac-44c7-b9a4-e9029c06149b", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99688627-a019-4f6c-9a1e-5466526f4c0a", "f985009e-ea04-41b4-995d-6773852efaec", "Admin", "Admin" });
        }
    }
}
