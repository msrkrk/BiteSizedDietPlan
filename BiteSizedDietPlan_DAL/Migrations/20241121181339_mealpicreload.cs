using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiteSizedDietPlan_DAL.Migrations
{
    /// <inheritdoc />
    public partial class mealpicreload : Migration
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

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
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
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePath",
                value: "\"C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg\"");
        }
    }
}
