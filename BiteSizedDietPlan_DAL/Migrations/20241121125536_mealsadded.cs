using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiteSizedDietPlan_DAL.Migrations
{
    /// <inheritdoc />
    public partial class mealsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yemekler");

            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Meyve ve Sebzeler");

            migrationBuilder.InsertData(
                table: "MealCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[] { 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçecekler" });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calorie", "CreatedDate", "MealCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Yulaf Ezmesi ve Meyve" },
                    { 2, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Peynirli Omlet" },
                    { 3, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tam Tahıllı Tost" },
                    { 4, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Avokadolu Tam Tahıllı Ekmek" },
                    { 5, 270, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sebzeli Gözleme" },
                    { 6, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Yoğurtlu Meyve Kasesi" },
                    { 7, 220, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sebzeli Omlet" },
                    { 8, 280, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Zeytinli ve Peynirli Sandviç" },
                    { 9, 240, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sade Krep" },
                    { 10, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Fıstık Ezmeli Muzlu Tost" },
                    { 11, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Izgara Tavuk Salatası" },
                    { 12, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sebzeli Kinoa" },
                    { 13, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mercimek Çorbası ve Tam Buğday Ekmeği" },
                    { 14, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Zeytinyağlı Enginar" },
                    { 15, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Izgara Hindi ve Sebze Tabağı" },
                    { 16, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Domates Soslu Spagetti" },
                    { 17, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nohutlu Bulgur Pilavı" },
                    { 18, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Zeytinyağlı Taze Fasulye" },
                    { 19, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Fırında Köfte ve Sebzeler" },
                    { 20, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tavuklu Sebzeli Dürüm" },
                    { 21, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Izgara Somon ve Sebzeler" },
                    { 22, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Zeytinyağlı Barbunya" },
                    { 23, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sebzeli Bulgur Pilavı" },
                    { 24, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Fırında Tavuk ve Patates" },
                    { 25, 380, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Fırında Somonlu Sebze Graten" },
                    { 26, 350, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tavuklu Kabak Spagetti" },
                    { 27, 300, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Balık Çorbası ve Salata" },
                    { 28, 450, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Etli Kuru Fasulye ve Pirinç Pilavı" },
                    { 29, 400, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sebzeli Lazanya" },
                    { 30, 320, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Fırında Karnabahar Mücveri" },
                    { 31, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Yoğurt ve Çilek" },
                    { 32, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Badem ve Ceviz Karışımı" },
                    { 33, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Havuç ve Humus" },
                    { 34, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Tam Buğday Kraker ve Peynir" },
                    { 35, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Elma ve Fıstık Ezmesi" },
                    { 36, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Muz ve Yoğurt Kasesi" },
                    { 37, 250, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Protein Bar (Ev Yapımı)" },
                    { 38, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Cevizli Kuru Üzüm Karışımı" },
                    { 39, 130, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Haşlanmış Yumurta ve Zeytin" },
                    { 40, 200, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ev Yapımı Smoothie" },
                    { 41, 95, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Elma" },
                    { 42, 100, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Armut" },
                    { 43, 105, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Muz" },
                    { 44, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Portakal" },
                    { 45, 50, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Çilek" },
                    { 46, 42, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Kivi" },
                    { 47, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Üzüm (1 Porsiyon)" },
                    { 48, 58, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Şeftali" },
                    { 49, 20, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Erik (5 Adet)" },
                    { 50, 47, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mandalina" },
                    { 51, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Havuç (1 Adet)" },
                    { 52, 15, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Salatalık (1 Adet)" },
                    { 53, 30, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Biber (1 Adet)" },
                    { 54, 22, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Domates (1 Adet)" },
                    { 55, 10, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Kereviz Sapı (2 Dal)" },
                    { 56, 35, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Taze Fasulye (1 Porsiyon)" },
                    { 57, 23, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ispanak (100 gr)" },
                    { 58, 50, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Brokoli (1 Porsiyon)" },
                    { 59, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Karnabahar (1 Porsiyon)" },
                    { 60, 62, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Bezelye (1 Porsiyon)" },
                    { 61, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Beyaz Peynir (50 gr)" },
                    { 62, 150, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kaşar Peyniri (50 gr)" },
                    { 63, 180, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tulum Peyniri (50 gr)" },
                    { 64, 70, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Yeşil Zeytin (10 Adet)" },
                    { 65, 75, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Siyah Zeytin (10 Adet)" },
                    { 66, 20, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Domates ve Salatalık (100 gr)" },
                    { 67, 68, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Haşlanmış Yumurta (1 Adet)" },
                    { 68, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bal (1 Tatlı Kaşığı)" },
                    { 69, 30, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Reçel (1 Tatlı Kaşığı)" },
                    { 70, 45, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tereyağı (1 Tatlı Kaşığı)" },
                    { 71, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Su (1 Bardak)" },
                    { 72, 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Sade Türk Kahvesi (1 Fincan)" },
                    { 73, 2, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Çay (Şekersiz, 1 Bardak)" },
                    { 74, 120, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Taze Sıkılmış Portakal Suyu (1 Bardak)" },
                    { 75, 25, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Limonata (Şekersiz, 1 Bardak)" },
                    { 76, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Yeşil Çay (Şekersiz, 1 Bardak)" },
                    { 77, 60, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Ayran (1 Bardak)" },
                    { 78, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Soda (1 Şişe)" },
                    { 79, 0, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Maden Suyu (1 Şişe)" },
                    { 80, 80, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Süt (Yağsız, 1 Bardak)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Öğle Yemekleri");

            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Akşam Yemekleri");
        }
    }
}
