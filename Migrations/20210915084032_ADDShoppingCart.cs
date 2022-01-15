using Microsoft.EntityFrameworkCore.Migrations;

namespace Projet.ASP.NET.Core.MVC.Migrations
{
    public partial class ADDShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BooKId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartSessionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Books_BooKId",
                        column: x => x.BooKId,
                        principalTable: "Books",
                        principalColumn: "BooKId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BooKId",
                keyValue: 4,
                column: "ImageurUrl",
                value: "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BooKId",
                keyValue: 5,
                column: "ImageurUrl",
                value: "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BooKId",
                table: "ShoppingCartItems",
                column: "BooKId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BooKId",
                keyValue: 4,
                column: "ImageurUrl",
                value: "https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BooKId",
                keyValue: 5,
                column: "ImageurUrl",
                value: "https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg");
        }
    }
}
