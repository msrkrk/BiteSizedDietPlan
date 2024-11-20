using BiteSizedDietPlan_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
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

            //Seed data ile yemek kategorileri eklendi.
            modelBuilder.Entity<MealCategory>().HasData(
            new MealCategory { Id = 1, Name = "Kahvaltılıklar" },
            new MealCategory { Id = 2, Name = "Öğle Yemekleri" },
            new MealCategory { Id = 3, Name = "Akşam Yemekleri" },
            new MealCategory { Id = 4, Name = "Atıştırmalıklar" });

        }


    }
}
