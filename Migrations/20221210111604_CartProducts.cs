using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Comm.Migrations
{
    public partial class CartProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0413eacf-2aca-410c-b476-5562cebe3abf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a2bfea0-e71b-487f-816c-198af7b237b8");

            migrationBuilder.DropColumn(
                name: "ProductIdFK",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "UserIdFK",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "ProductIdFK",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "UsernameFK",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "carts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UsernameFK",
                table: "carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    cartsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.ProductsId, x.cartsId });
                    table.ForeignKey(
                        name: "FK_CartProduct_carts_cartsId",
                        column: x => x.cartsId,
                        principalTable: "carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19e3023a-24fe-4c5f-8034-638dcf175e55", "3631f17b-26e9-4ae2-9882-3b38236f8a02", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fca6035-ea70-47d2-998c-f9f3b5499a91", "ab42d757-7e3f-4136-a86d-5414129e0c67", "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_cartsId",
                table: "CartProduct",
                column: "cartsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e3023a-24fe-4c5f-8034-638dcf175e55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fca6035-ea70-47d2-998c-f9f3b5499a91");

            migrationBuilder.DropColumn(
                name: "UsernameFK",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "UsernameFK",
                table: "carts");

            migrationBuilder.AddColumn<int>(
                name: "ProductIdFK",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIdFK",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductIdFK",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0413eacf-2aca-410c-b476-5562cebe3abf", "7613a3bd-21ac-4686-9b07-bf04fffe2d61", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a2bfea0-e71b-487f-816c-198af7b237b8", "b17ae65d-bbc3-43e4-93dc-db546eb768ef", "Admin", "Admin" });
        }
    }
}
