using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiteSizedDietPlan_DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<int>(type: "int", nullable: false),
                    MealCategoryId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_MealCategories_MealCategoryId",
                        column: x => x.MealCategoryId,
                        principalTable: "MealCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodEntries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodEntryMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodEntryId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodEntryMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodEntryMeals_FoodEntries_FoodEntryId",
                        column: x => x.FoodEntryId,
                        principalTable: "FoodEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodEntryMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MealCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kahvaltılıklar" },
                    { 2, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yemekler" },
                    { 3, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meyve ve Sebzeler" },
                    { 4, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atıştırmalıklar" },
                    { 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçecekler" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calorie", "CreatedDate", "ImagePath", "MealCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Yulaf Ezmesi ve Meyve" },
                    { 2, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Peynirli Omlet" },
                    { 3, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Tam Tahıllı Tost" },
                    { 4, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Avokadolu Tam Tahıllı Ekmek" },
                    { 5, 270, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Sebzeli Gözleme" },
                    { 6, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Yoğurtlu Meyve Kasesi" },
                    { 7, 220, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Sebzeli Omlet" },
                    { 8, 280, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Zeytinli ve Peynirli Sandviç" },
                    { 9, 240, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Sade Krep" },
                    { 10, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Fıstık Ezmeli Muzlu Tost" },
                    { 11, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Izgara Tavuk Salatası" },
                    { 12, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Sebzeli Kinoa" },
                    { 13, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Mercimek Çorbası ve Tam Buğday Ekmeği" },
                    { 14, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Zeytinyağlı Enginar" },
                    { 15, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Izgara Hindi ve Sebze Tabağı" },
                    { 16, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Domates Soslu Spagetti" },
                    { 17, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Nohutlu Bulgur Pilavı" },
                    { 18, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Zeytinyağlı Taze Fasulye" },
                    { 19, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Fırında Köfte ve Sebzeler" },
                    { 20, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Tavuklu Sebzeli Dürüm" },
                    { 21, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Izgara Somon ve Sebzeler" },
                    { 22, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Zeytinyağlı Barbunya" },
                    { 23, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Sebzeli Bulgur Pilavı" },
                    { 24, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Fırında Tavuk ve Patates" },
                    { 25, 380, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Fırında Somonlu Sebze Graten" },
                    { 26, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Tavuklu Kabak Spagetti" },
                    { 27, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Balık Çorbası ve Salata" },
                    { 28, 450, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Etli Kuru Fasulye ve Pirinç Pilavı" },
                    { 29, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Sebzeli Lazanya" },
                    { 30, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 2, "Fırında Karnabahar Mücveri" },
                    { 31, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Yoğurt ve Çilek" },
                    { 32, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Badem ve Ceviz Karışımı" },
                    { 33, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Havuç ve Humus" },
                    { 34, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Tam Buğday Kraker ve Peynir" },
                    { 35, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Elma ve Fıstık Ezmesi" },
                    { 36, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Muz ve Yoğurt Kasesi" },
                    { 37, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Protein Bar (Ev Yapımı)" },
                    { 38, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Cevizli Kuru Üzüm Karışımı" },
                    { 39, 130, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Haşlanmış Yumurta ve Zeytin" },
                    { 40, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 4, "Ev Yapımı Smoothie" },
                    { 41, 95, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Elma" },
                    { 42, 100, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Armut" },
                    { 43, 105, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Muz" },
                    { 44, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Portakal" },
                    { 45, 50, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Çilek" },
                    { 46, 42, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Kivi" },
                    { 47, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Üzüm (1 Porsiyon)" },
                    { 48, 58, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Şeftali" },
                    { 49, 20, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Erik (5 Adet)" },
                    { 50, 47, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Mandalina" },
                    { 51, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Havuç (1 Adet)" },
                    { 52, 15, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Salatalık (1 Adet)" },
                    { 53, 30, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Biber (1 Adet)" },
                    { 54, 22, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Domates (1 Adet)" },
                    { 55, 10, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Kereviz Sapı (2 Dal)" },
                    { 56, 35, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Taze Fasulye (1 Porsiyon)" },
                    { 57, 23, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Ispanak (100 gr)" },
                    { 58, 50, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Brokoli (1 Porsiyon)" },
                    { 59, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Karnabahar (1 Porsiyon)" },
                    { 60, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 3, "Bezelye (1 Porsiyon)" },
                    { 61, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Beyaz Peynir (50 gr)" },
                    { 62, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Kaşar Peyniri (50 gr)" },
                    { 63, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Tulum Peyniri (50 gr)" },
                    { 64, 70, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Yeşil Zeytin (10 Adet)" },
                    { 65, 75, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Siyah Zeytin (10 Adet)" },
                    { 66, 20, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Domates ve Salatalık (100 gr)" },
                    { 67, 68, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Haşlanmış Yumurta (1 Adet)" },
                    { 68, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Bal (1 Tatlı Kaşığı)" },
                    { 69, 30, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Reçel (1 Tatlı Kaşığı)" },
                    { 70, 45, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 1, "Tereyağı (1 Tatlı Kaşığı)" },
                    { 71, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Su (1 Bardak)" },
                    { 72, 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Sade Türk Kahvesi (1 Fincan)" },
                    { 73, 2, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Çay (Şekersiz, 1 Bardak)" },
                    { 74, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Taze Sıkılmış Portakal Suyu (1 Bardak)" },
                    { 75, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Limonata (Şekersiz, 1 Bardak)" },
                    { 76, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Yeşil Çay (Şekersiz, 1 Bardak)" },
                    { 77, 60, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Ayran (1 Bardak)" },
                    { 78, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Soda (1 Şişe)" },
                    { 79, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Maden Suyu (1 Şişe)" },
                    { 80, 80, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg", 5, "Süt (Yağsız, 1 Bardak)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntries_UserId",
                table: "FoodEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntryMeals_FoodEntryId",
                table: "FoodEntryMeals",
                column: "FoodEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntryMeals_MealId",
                table: "FoodEntryMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealCategoryId",
                table: "Meals",
                column: "MealCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodEntryMeals");

            migrationBuilder.DropTable(
                name: "FoodEntries");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MealCategories");
        }
    }
}
