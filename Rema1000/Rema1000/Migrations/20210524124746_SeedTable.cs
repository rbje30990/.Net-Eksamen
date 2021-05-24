using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000.Migrations
{
    public partial class SeedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Product",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Kilograms",
                table: "Product",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "Cakes");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 2, "Used after eating cake", "Toothpaste" });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Address", "ContactPerson", "Email", "Name", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Abildvej", "Mike Johnson", "mikeJohn@gmail.com", "Mike Johnson", "+45 32 53 23 95", 7100 },
                    { 2, "Frejasgade", "Susanne Jensen", "susjensen@gmail.com", "Susanne Jensen", "+45 74 66 84 61", 8700 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "Kilograms", "Name", "Price", "QuantityInPackage", "Stock", "SupplierId" },
                values: new object[,]
                {
                    { 1, 1, "Yes please", 1.5, "Cheesecake", 250.0, 1, 30, 1 },
                    { 3, 2, "Wonderful taste", 0.10000000000000001, "Colgate", 20.989999999999998, 3, 1400, 1 },
                    { 2, 1, "But what about Andrea?", 2.3999999999999999, "KajKage", 50.0, 5, 1001, 2 },
                    { 4, 2, "Healthy mouth control paste", 0.20000000000000001, "Jason", 35.0, 1, 100, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Product",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Kilograms",
                table: "Product",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "Cake");
        }
    }
}
