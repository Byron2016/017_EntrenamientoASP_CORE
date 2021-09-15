using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjEmptyWebApplicationCore.Migrations
{
    public partial class seedAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Author 1" },
                    { 2, "Author 2" },
                    { 3, "Author 3" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 49, 1, 354, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 49, 1, 354, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 49, 1, 354, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 49, 1, 354, DateTimeKind.Utc).AddTicks(1662));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 47, 8, 277, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 47, 8, 277, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 47, 8, 277, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 9, 15, 14, 47, 8, 277, DateTimeKind.Utc).AddTicks(5559));
        }
    }
}
