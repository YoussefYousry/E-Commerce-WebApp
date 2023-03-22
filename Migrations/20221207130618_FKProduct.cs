using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class FKProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b102563-54ba-49b9-bc86-d399efc4e086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec96caf3-024a-4588-891b-b30b915e6bc1");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0413eacf-2aca-410c-b476-5562cebe3abf", "7613a3bd-21ac-4686-9b07-bf04fffe2d61", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a2bfea0-e71b-487f-816c-198af7b237b8", "b17ae65d-bbc3-43e4-93dc-db546eb768ef", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0413eacf-2aca-410c-b476-5562cebe3abf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a2bfea0-e71b-487f-816c-198af7b237b8");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b102563-54ba-49b9-bc86-d399efc4e086", "af33580d-b31e-448a-9599-357236ce460d", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec96caf3-024a-4588-891b-b30b915e6bc1", "c681cafd-da43-4864-b490-9baf8446493e", "Admin", "Admin" });
        }
    }
}
