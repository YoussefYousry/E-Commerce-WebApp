using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class ProductID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_products_productId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_productId",
                table: "products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156ce0b3-9aec-4bbd-b856-ce427cee1c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb2f7e19-5342-4f97-83cd-76c11d143806");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b102563-54ba-49b9-bc86-d399efc4e086", "af33580d-b31e-448a-9599-357236ce460d", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec96caf3-024a-4588-891b-b30b915e6bc1", "c681cafd-da43-4864-b490-9baf8446493e", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b102563-54ba-49b9-bc86-d399efc4e086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec96caf3-024a-4588-891b-b30b915e6bc1");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "156ce0b3-9aec-4bbd-b856-ce427cee1c0e", "bd53dd64-9aff-4c19-9c09-b9794fed655b", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb2f7e19-5342-4f97-83cd-76c11d143806", "e00b6c53-e313-4bd8-91c2-216ace4a10e8", "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_products_productId",
                table: "products",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_products_productId",
                table: "products",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id");
        }
    }
}
