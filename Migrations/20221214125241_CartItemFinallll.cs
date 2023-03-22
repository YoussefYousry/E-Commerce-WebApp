using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartItemFinallll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "46a64884-05cd-44b0-b2bf-9b4bcd24537e", "7c8d5f89-f010-420e-92a8-aefe118897f1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61311d71-a285-4dbd-a2a6-c6ba55c68e08", "3557f552-ef3a-4918-b154-ab392d3981f8", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a64884-05cd-44b0-b2bf-9b4bcd24537e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61311d71-a285-4dbd-a2a6-c6ba55c68e08");

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
    }
}
