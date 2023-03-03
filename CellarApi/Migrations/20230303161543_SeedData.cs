using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CellarApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Appellation", "Climate", "Country", "Soil" },
                values: new object[] { 1, "Dundee Hills AVA", "Cool", "USA", "Jory" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 1);
        }
    }
}
