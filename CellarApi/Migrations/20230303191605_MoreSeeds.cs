using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CellarApi.Migrations
{
    public partial class MoreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Appellation", "Climate", "Country", "Soil" },
                values: new object[,]
                {
                    { 2, "Champage AOC", "Cool", "France", "Chalk" },
                    { 3, "Chablis AOC", "Cool", "France", "Limestone" },
                    { 4, "Rioja DOCa", "Warm", "Spain", "Alluvial" },
                    { 5, "Chianti DOCG", "Warm", "Italy", "Galestro" },
                    { 6, "Barossa Valley", "Warm", "Australia", "Sandy Clay" },
                    { 7, "Marlborough", "Cool", "New Zealand", "Alluvial" },
                    { 8, "Barolo DOCG", "Cool", "Italy", "Clay" },
                    { 9, "Bourgogne AOC", "Cool", "France", "Clay" },
                    { 10, "Muscadet AOC", "Cool", "France", "Gneiss" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 10);
        }
    }
}
