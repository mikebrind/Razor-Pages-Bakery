using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 1, "A scrumptious mini-carrot cake encrusted with sliced almonds", "carrot_cake.jpg", "Carrot Cake", 8.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 2, "A delicious lemon tart with fresh meringue cooked to perfection", "lemon_tart.jpg", "Lemon Tart", 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 3, "Delectable vanilla and chocolate cupcakes", "cupcakes.jpg", "Cupcakes", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 4, "Fresh baked French-style bread", "bread.jpg", "Bread", 1.49m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 5, "A glazed pear tart topped with sliced almonds and a dash of cinnamon", "pear_tart.jpg", "Pear Tart", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 6, "Rich chocolate frosting cover this chocolate lover's dream", "chocolate_cake.jpg", "Chocolate Cake", 8.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
