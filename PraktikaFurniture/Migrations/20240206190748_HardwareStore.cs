using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraktikaFurniture.Migrations
{
    /// <inheritdoc />
    public partial class HardwareStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__B40CC6ED9AA27175", x => x.ProductID);
                });
            migrationBuilder.Sql("insert into Product values\r\n('Laptop', 1000, 'шт', 10),\r\n('Smartphone', 500, 'шт', 20),\r\n('Headphones', 50, 'шт', 30),\r\n('Tablet', 800, 'шт', 15),\r\n('Smartwatch', 200, 'шт', 25),\r\n('Camera', 600, 'шт', 12),\r\n('Printer', 300, 'шт', 18),\r\n('Monitor', 400, 'шт', 22),\r\n('Keyboard', 30, 'шт', 40),\r\n('Mouse', 20, 'шт', 50),\r\n('Speaker', 70, 'шт', 35),\r\n('Router', 80, 'шт', 28),\r\n('External Hard Drive', 120, 'шт', 17),\r\n('USB Flash Drive', 10, 'шт', 60),\r\n('Microphone', 90, 'шт', 33),\r\n('Webcam', 40, 'шт', 45),\r\n('Game Console', 350, 'шт', 13),\r\n('E-reader', 150, 'шт', 23),\r\n('Power Bank', 25, 'шт', 55),\r\n('Fitness Tracker', 75, 'шт', 27)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
