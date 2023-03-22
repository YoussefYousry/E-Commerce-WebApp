using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinalll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a61d6251-6cb0-479a-bf68-0042aeac181a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4b39144-d79e-4614-a73d-1f6c68e04036");

            migrationBuilder.DropColumn(
                name: "CartIdFK",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "465087be-1770-46cc-a837-eae5d70ecef8", "a31cc58e-bd5c-4a68-b585-b1d803734c1a", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b99b97ad-cb7c-4385-a3ec-3254900da01e", "d909b9dc-da54-43d4-a61f-30a795b1f57d", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "465087be-1770-46cc-a837-eae5d70ecef8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b99b97ad-cb7c-4385-a3ec-3254900da01e");

            migrationBuilder.AddColumn<int>(
                name: "CartIdFK",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a61d6251-6cb0-479a-bf68-0042aeac181a", "49ef8a9a-5f9e-4239-89c9-5c027031ceb7", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4b39144-d79e-4614-a73d-1f6c68e04036", "2c414bba-1964-497c-81e2-437126ddb72b", "User", "User" });
        }
    }
}
