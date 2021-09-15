using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjEmptyWebApplicationCore.Migrations
{
    public partial class seedBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverUrl", "DataRead", "DateAdded", "Description", "Genre", "IsRead", "PublisherId", "Rate", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", "Url 1", null, new DateTime(2021, 9, 15, 14, 18, 37, 422, DateTimeKind.Utc).AddTicks(8566), "Desc 1", "Fiction", false, 1, 1, "Title 1" },
                    { 2, "Author 2", "Url 2", null, new DateTime(2021, 9, 15, 14, 18, 37, 422, DateTimeKind.Utc).AddTicks(9660), "Desc 2", "Fiction", false, 2, 1, "Title 2" },
                    { 3, "Author 3", "Url 3", null, new DateTime(2021, 9, 15, 14, 18, 37, 422, DateTimeKind.Utc).AddTicks(9677), "Desc 3", "Fiction", false, 1, 1, "Title 3" },
                    { 4, "Author 4", "Url 4", null, new DateTime(2021, 9, 15, 14, 18, 37, 422, DateTimeKind.Utc).AddTicks(9680), "Desc 4", "Fiction", false, 4, 1, "Title 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
