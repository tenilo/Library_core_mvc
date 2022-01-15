using Microsoft.EntityFrameworkCore.Migrations;

namespace Projet.ASP.NET.Core.MVC.Migrations
{
    public partial class CreatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BooKId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageurUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BooKId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Big data", "books of big data" },
                    { 2, "Database", "books of database" },
                    { 3, "Front-End", "books of Front-End" },
                    { 4, "Back-End", "books of Back-End" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BooKId", "CategoryId", "ImageurUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Big Data for Dummies", 98m, "big data management is one of the major" },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Big Data", 120.90m, "Bernard Marr's Data strategy is a must-have guide to creating a robust data strategy" },
                    { 3, 2, "https://images-na.ssl-images-amazon.com/images/I/51UvR3a63OL._SX379_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Data Engineering", 66m, "This book has been an evolving dream of ours for about five years." },
                    { 4, 2, "https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Data-Intensive", 66m, "The big ideas behind reliable, scalable, and maintainable systems" },
                    { 5, 3, "https://images-na.ssl-images-amazon.com/images/I/51gp9mXEqWL._SX379_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Angular", 66m, "The big ideas behind reliable, scalable, and maintainable systems" },
                    { 6, 3, "https://images-na.ssl-images-amazon.com/images/I/51Q43WRXJzL.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Learning React", 89m, "Developped by facebook, and used by companies including netflix" },
                    { 7, 4, "https://images-na.ssl-images-amazon.com/images/I/413Z89zzezL._SX348_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Pro C# 7", 55.60m, "Dive in and discover why pro c# has been a favorite" },
                    { 8, 4, "https://images-na.ssl-images-amazon.com/images/I/41NGBmeH1uL._SX403_BO1,204,203,200_.jpg", true, "management big data is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace of traditional data management tools.", "Learning Node.js", 98m, "Dive in and discover why pro c# has been a favorite" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
