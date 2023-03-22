using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemLastt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d38424d-e955-460f-a38d-6e6cb60dc7f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ceccf3-52fe-4dbe-aeac-4678730a677f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "752fb866-fd16-490b-b887-42e3f6d827b6", "04b26f8b-1cf4-4abd-bd1f-9773c90ae051", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "92bf4849-0ee4-456a-b9be-0babc6b94573", "6a449bea-689d-406b-92fe-4c8b8705af83", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "752fb866-fd16-490b-b887-42e3f6d827b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92bf4849-0ee4-456a-b9be-0babc6b94573");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d38424d-e955-460f-a38d-6e6cb60dc7f9", "92c7acee-8479-4bd8-a9ae-ca6d1d16c526", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6ceccf3-52fe-4dbe-aeac-4678730a677f", "0982064c-239e-4fe7-93b0-7be8f5292ae3", "Admin", "Admin" });
        }
    }
}
