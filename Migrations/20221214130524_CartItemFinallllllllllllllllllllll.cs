using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinallllllllllllllllllllll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28f37299-7134-440e-a003-23f7154309f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a9173ec-93ad-4086-9137-7d7c596591e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fdda46e-7ca7-4bc8-af86-7a5202fa448a", "f02c6bfe-8e44-405a-a806-9c986e5e5711", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47c7835b-b1de-48a3-8bf2-fab0fb983349", "c2bae4e0-323c-41a2-94be-a10222d704b8", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fdda46e-7ca7-4bc8-af86-7a5202fa448a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47c7835b-b1de-48a3-8bf2-fab0fb983349");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28f37299-7134-440e-a003-23f7154309f3", "089ed8c9-4723-4336-b19f-c0cd5a4e57eb", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a9173ec-93ad-4086-9137-7d7c596591e4", "c54a5f67-4aee-4717-9bee-a1ec1cc6bb1f", "User", "User" });
        }
    }
}
