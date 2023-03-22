using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class ProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deca8998-a4d6-4b91-824c-b8af979a142a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6103363-7e42-48a7-9ec5-ed22f8ec122d");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "products",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "156ce0b3-9aec-4bbd-b856-ce427cee1c0e", "bd53dd64-9aff-4c19-9c09-b9794fed655b", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb2f7e19-5342-4f97-83cd-76c11d143806", "e00b6c53-e313-4bd8-91c2-216ace4a10e8", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156ce0b3-9aec-4bbd-b856-ce427cee1c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb2f7e19-5342-4f97-83cd-76c11d143806");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "deca8998-a4d6-4b91-824c-b8af979a142a", "fe34ead2-8c0c-4bc3-9f08-b7f395f59f5f", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6103363-7e42-48a7-9ec5-ed22f8ec122d", "24721f6b-6618-4a65-b271-191c810883e9", "Admin", "Admin" });
        }
    }
}
