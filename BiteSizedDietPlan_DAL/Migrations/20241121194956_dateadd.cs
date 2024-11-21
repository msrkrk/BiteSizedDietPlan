using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiteSizedDietPlan_DAL.Migrations
{
    /// <inheritdoc />
    public partial class dateadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "FoodEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "FoodEntries");
        }
    }
}
