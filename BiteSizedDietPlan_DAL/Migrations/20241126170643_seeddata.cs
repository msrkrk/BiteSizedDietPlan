using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiteSizedDietPlan_DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://picsum.photos/200");
        }
    }
}
