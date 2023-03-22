using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c8008c7-f53d-42f6-a8a9-9f7185d4cf4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d012b5ae-b185-4d0c-a62c-175559aed50d");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartItems",
                newName: "CartIdFK");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a61d6251-6cb0-479a-bf68-0042aeac181a", "49ef8a9a-5f9e-4239-89c9-5c027031ceb7", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4b39144-d79e-4614-a73d-1f6c68e04036", "2c414bba-1964-497c-81e2-437126ddb72b", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a61d6251-6cb0-479a-bf68-0042aeac181a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4b39144-d79e-4614-a73d-1f6c68e04036");

            migrationBuilder.RenameColumn(
                name: "CartIdFK",
                table: "CartItems",
                newName: "CartId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c8008c7-f53d-42f6-a8a9-9f7185d4cf4f", "d34cd5ef-9200-420d-8cb3-ec7c2e68129e", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d012b5ae-b185-4d0c-a62c-175559aed50d", "3caf893f-2fd5-404a-a650-fa2e7bd8b122", "Admin", "Admin" });
        }
    }
}
