using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjEmptyWebApplicationCore.Migrations
{
    public partial class seedPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Publi 1" },
                    { 2, "Publi 2" },
                    { 3, "Publi 3" },
                    { 4, "Publi 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
