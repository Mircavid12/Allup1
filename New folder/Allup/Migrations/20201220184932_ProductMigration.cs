using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class ProductMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Code", "Count", "Description", "Discount", "ExTax", "IsDeleted", "Price", "Rate", "SaleCount", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 11.9, 5, 1, "drone, camera", "Cale 6 eu accumsan massa facilisis Madden by Steve" },
                    { 2, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 23.899999999999999, 5, 1, "drone, camera", "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker" },
                    { 3, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 23.899999999999999, 3.0, false, 21.899999999999999, 5, 1, "drone, camera", "Originals Kaval Wind breaker Winter Jacket eu..." },
                    { 4, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 35.899999999999999, 5, 1, "drone, camera", "Juicy Couture Juicy Quilted Terry Track Jacket eu..." },
                    { 5, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 11.9, 5, 1, "drone, camera", "Madden by Steve Madden Cale 6 eu accumsan massa..." },
                    { 6, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 11.9, 5, 1, "drone, camera", "Trans-Weight Hooded Wind and Water Resistant Shell" },
                    { 7, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 11.9, 5, 1, "drone, camera", "Water and Wind Resistant Insulated Jacket eu massa" },
                    { 8, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 11.9, 5, 1, "drone, camera", "New Balance Fresh Foam Kaymin eu accumsan massa..." },
                    { 9, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 18.899999999999999, 5, 1, "drone, camera", "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan.." },
                    { 10, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 18.899999999999999, 5, 1, "drone, camera", "New Balance Fresh Foam LAZR v1 Sport eu accumsan..." },
                    { 11, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 0.0, 3.0, false, 29.899999999999999, 5, 1, "drone, camera", "Cale 6 eu accumsan massa facilisis Madden by Steve" },
                    { 12, "Brac", "abcd1234", 0, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptas consectetur inventore voluptatem dignissimos nemo repellendus est, harum maiores veritatis quidem.", 29.0, 3.0, false, 26.100000000000001, 5, 1, "drone, camera", "New Balance Arishi Sport v1Couture Juicy eu" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Image", "ProductId" },
                values: new object[,]
                {
                    { 1, "product-1.jpg", 1 },
                    { 17, "product-3.jpg", 11 },
                    { 16, "product-15.jpg", 10 },
                    { 15, "product-14.jpg", 10 },
                    { 14, "product-8.jpg", 9 },
                    { 13, "product-13.jpg", 8 },
                    { 12, "product-7.jpg", 7 },
                    { 11, "product-6.jpg", 7 },
                    { 18, "product-9.jpg", 11 },
                    { 10, "product-6.jpg", 6 },
                    { 8, "product-5.jpg", 5 },
                    { 7, "product-12.jpg", 4 },
                    { 6, "product-4.jpg", 3 },
                    { 5, "product-3.jpg", 3 },
                    { 4, "product-11.jpg", 2 },
                    { 3, "product-10.jpg", 2 },
                    { 2, "product-2.jpg", 1 },
                    { 9, "product-16.jpg", 6 },
                    { 19, "product-9.jpg", 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
