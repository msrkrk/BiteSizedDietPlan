using BiteSizedDietPlan_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodEntry> FoodEntries { get; set; }
        public DbSet<FoodEntryMeal> FoodEntryMeals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.211.55.2;database=BiteSizedDietPlanDb;user id=sa;password=Qwq1234.;trustservercertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique(); // E-posta alanını benzersiz yapar.

            // MealsCategories ile Meal arasında bire-çok ilişkiyi tanımlandı.
            modelBuilder.Entity<Meal>()
                .HasOne(m => m.MealCategory)
                .WithMany(c => c.Meals)
                .HasForeignKey(m => m.MealCategoryId);

            // User - FoodEntry: 1-M İlişki
            modelBuilder.Entity<FoodEntry>()
                .HasOne(fe => fe.User)
                .WithMany(u => u.FoodEntries)
                .HasForeignKey(fe => fe.UserId);

            // FoodEntry - Meal: M-N İlişki
            modelBuilder.Entity<FoodEntryMeal>()
                .HasOne(fem => fem.FoodEntry)
                .WithMany(fe => fe.FoodEntryMeals)
                .HasForeignKey(fem => fem.FoodEntryId);

            modelBuilder.Entity<FoodEntryMeal>()
                .HasOne(fem => fem.Meal)
                .WithMany(m => m.FoodEntryMeals)
                .HasForeignKey(fem => fem.MealId);

            //Seed data ile yemek kategorileri eklendi.
            modelBuilder.Entity<MealCategory>().HasData(
                new MealCategory { Id = 1, Name = "Kahvaltılıklar", CreatedDate = new DateTime(2024, 11, 21) },
                new MealCategory { Id = 2, Name = "Yemekler", CreatedDate = new DateTime(2024, 11, 21) },
                new MealCategory { Id = 3, Name = "Meyve ve Sebzeler", CreatedDate = new DateTime(2024, 11, 21) },
                new MealCategory { Id = 4, Name = "Atıştırmalıklar", CreatedDate = new DateTime(2024, 11, 21) },
                new MealCategory { Id = 5, Name = "İçecekler", CreatedDate = new DateTime(2024, 11, 21) }
            );

            //Seed data ile yemekler eklendi.
            modelBuilder.Entity<Meal>().HasData(
                new Meal { Id = 1, Name = "Yulaf Ezmesi ve Meyve", Calorie = 250, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21) , ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 2, Name = "Peynirli Omlet", Calorie = 200, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 3, Name = "Tam Tahıllı Tost", Calorie = 300, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 4, Name = "Avokadolu Tam Tahıllı Ekmek", Calorie = 250, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg"  },
                new Meal { Id = 5, Name = "Sebzeli Gözleme", Calorie = 270, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 6, Name = "Yoğurtlu Meyve Kasesi", Calorie = 200, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 7, Name = "Sebzeli Omlet", Calorie = 220, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 8, Name = "Zeytinli ve Peynirli Sandviç", Calorie = 280, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 9, Name = "Sade Krep", Calorie = 240, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 10, Name = "Fıstık Ezmeli Muzlu Tost", Calorie = 320, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 11, Name = "Izgara Tavuk Salatası", Calorie = 350, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 12, Name = "Sebzeli Kinoa", Calorie = 320, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 13, Name = "Mercimek Çorbası ve Tam Buğday Ekmeği", Calorie = 300, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 14, Name = "Zeytinyağlı Enginar", Calorie = 250, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 15, Name = "Izgara Hindi ve Sebze Tabağı", Calorie = 400, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 16, Name = "Domates Soslu Spagetti", Calorie = 350, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 17, Name = "Nohutlu Bulgur Pilavı", Calorie = 320, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 18, Name = "Zeytinyağlı Taze Fasulye", Calorie = 300, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 19, Name = "Fırında Köfte ve Sebzeler", Calorie = 400, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 20, Name = "Tavuklu Sebzeli Dürüm", Calorie = 350, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 21, Name = "Izgara Somon ve Sebzeler", Calorie = 400, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 22, Name = "Zeytinyağlı Barbunya", Calorie = 350, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 23, Name = "Sebzeli Bulgur Pilavı", Calorie = 320, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 24, Name = "Fırında Tavuk ve Patates", Calorie = 400, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 25, Name = "Fırında Somonlu Sebze Graten", Calorie = 380, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 26, Name = "Tavuklu Kabak Spagetti", Calorie = 350, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 27, Name = "Balık Çorbası ve Salata", Calorie = 300, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 28, Name = "Etli Kuru Fasulye ve Pirinç Pilavı", Calorie = 450, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 29, Name = "Sebzeli Lazanya", Calorie = 400, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 30, Name = "Fırında Karnabahar Mücveri", Calorie = 320, MealCategoryId = 2, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 31, Name = "Yoğurt ve Çilek", Calorie = 120, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 32, Name = "Badem ve Ceviz Karışımı", Calorie = 200, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 33, Name = "Havuç ve Humus", Calorie = 150, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 34, Name = "Tam Buğday Kraker ve Peynir", Calorie = 180, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 35, Name = "Elma ve Fıstık Ezmesi", Calorie = 150, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 36, Name = "Muz ve Yoğurt Kasesi", Calorie = 200, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 37, Name = "Protein Bar (Ev Yapımı)", Calorie = 250, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 38, Name = "Cevizli Kuru Üzüm Karışımı", Calorie = 180, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 39, Name = "Haşlanmış Yumurta ve Zeytin", Calorie = 130, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 40, Name = "Ev Yapımı Smoothie", Calorie = 200, MealCategoryId = 4, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 41, Name = "Elma", Calorie = 95, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 42, Name = "Armut", Calorie = 100, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 43, Name = "Muz", Calorie = 105, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 44, Name = "Portakal", Calorie = 62, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 45, Name = "Çilek", Calorie = 50, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 46, Name = "Kivi", Calorie = 42, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 47, Name = "Üzüm (1 Porsiyon)", Calorie = 62, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 48, Name = "Şeftali", Calorie = 58, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 49, Name = "Erik (5 Adet)", Calorie = 20, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 50, Name = "Mandalina", Calorie = 47, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 51, Name = "Havuç (1 Adet)", Calorie = 25, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 52, Name = "Salatalık (1 Adet)", Calorie = 15, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 53, Name = "Biber (1 Adet)", Calorie = 30, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 54, Name = "Domates (1 Adet)", Calorie = 22, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 55, Name = "Kereviz Sapı (2 Dal)", Calorie = 10, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 56, Name = "Taze Fasulye (1 Porsiyon)", Calorie = 35, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 57, Name = "Ispanak (100 gr)", Calorie = 23, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 58, Name = "Brokoli (1 Porsiyon)", Calorie = 50, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 59, Name = "Karnabahar (1 Porsiyon)", Calorie = 25, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 60, Name = "Bezelye (1 Porsiyon)", Calorie = 62, MealCategoryId = 3, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 61, Name = "Beyaz Peynir (50 gr)", Calorie = 120, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 62, Name = "Kaşar Peyniri (50 gr)", Calorie = 150, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 63, Name = "Tulum Peyniri (50 gr)", Calorie = 180, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 64, Name = "Yeşil Zeytin (10 Adet)", Calorie = 70, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 65, Name = "Siyah Zeytin (10 Adet)", Calorie = 75, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 66, Name = "Domates ve Salatalık (100 gr)", Calorie = 20, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 67, Name = "Haşlanmış Yumurta (1 Adet)", Calorie = 68, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 68, Name = "Bal (1 Tatlı Kaşığı)", Calorie = 25, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 69, Name = "Reçel (1 Tatlı Kaşığı)", Calorie = 30, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 70, Name = "Tereyağı (1 Tatlı Kaşığı)", Calorie = 45, MealCategoryId = 1, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 71, Name = "Su (1 Bardak)", Calorie = 0, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 72, Name = "Sade Türk Kahvesi (1 Fincan)", Calorie = 5, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 73, Name = "Çay (Şekersiz, 1 Bardak)", Calorie = 2, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 74, Name = "Taze Sıkılmış Portakal Suyu (1 Bardak)", Calorie = 120, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 75, Name = "Limonata (Şekersiz, 1 Bardak)", Calorie = 25, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 76, Name = "Yeşil Çay (Şekersiz, 1 Bardak)", Calorie = 0, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 77, Name = "Ayran (1 Bardak)", Calorie = 60, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 78, Name = "Soda (1 Şişe)", Calorie = 0, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 79, Name = "Maden Suyu (1 Şişe)", Calorie = 0, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" },
                new Meal { Id = 80, Name = "Süt (Yağsız, 1 Bardak)", Calorie = 80, MealCategoryId = 5, CreatedDate = new DateTime(2024, 11, 21), ImagePath = "C:\\Users\\msrkrk\\source\\repos\\BiteSizedDietPlan\\BiteSizedDietPlan\\Resources\\1.jpg" }
                );



        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();

            ChangeTracker.Clear();

            return result;
        }
    }
}
