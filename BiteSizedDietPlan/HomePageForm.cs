using AutoMapper;
using BiteSizedDietPlan.Models.MealViewModels;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_DAL.Entities;
using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiteSizedDietPlan
{
    public partial class HomePageForm : Form
    {
        private readonly UserViewModel _user;
        private readonly IMapper _mapper;
        private readonly IMealService _mealService;
        private readonly IFoodEntryService _foodEntryService;
     
        FoodEntryViewModel choosenFoodEntry;
        MealViewModel choosenMeal;
        FoodEntryMealViewModel choosenFoodEntryMeal;


        public HomePageForm(IMapper mapper, IMealService mealService, UserViewModel user, IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _mapper = mapper;
            _mealService = mealService;
            _user = user;
            _foodEntryService = foodEntryService;
        
            LoadMeals();
            LoadFoodEntries();
            ShowFoodEntries();
        }


        private void LoadMeals()
        {
            // FlowLayoutPanel'i temizle
            flpMeals.Controls.Clear();

            // Yemek verilerini al
            var meals = _mealService.GetMeals().ToList(); // Meals tablosundaki tüm veriler

            // Her bir yemek için bir buton oluştur
            foreach (var meal in meals)
            {
                Button mealButton = new Button();
                mealButton.Text = meal.Name; // Butonun metni yemek adı
                mealButton.Size = new Size(180, 180); // Butonun boyutunu ayarla

                // Eğer yemek resmi varsa, resmini ekle
                if (!string.IsNullOrEmpty(meal.ImagePath))
                {
                    try
                    {
                        mealButton.Image = Image.FromFile(meal.ImagePath); // Resmi yükle
                        mealButton.ImageAlign = ContentAlignment.TopCenter; // Resmin konumunu ayarla
                        mealButton.TextAlign = ContentAlignment.BottomCenter; // Metnin konumunu ayarla
                    }
                    catch (Exception ex)
                    {
                        // Resim yüklenemezse hata mesajı göster
                        MessageBox.Show("Resim yüklenemedi: " + ex.Message);
                    }
                }

                // Butona tıklandığında yapılacak işlemi belirle
                mealButton.Click += (sender, e) =>
                {
                    MessageBox.Show($"Yemek seçildi: {meal.Name}");
                };

                // Butonu FlowLayoutPanel'e ekle
                flpMeals.Controls.Add(mealButton);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadFoodEntries();
        }

        private void LoadFoodEntries()
        {
            var date = dateTimePicker.Value;
            var userId = _user.Id;

            var foodEntries = _foodEntryService.GetDailyFoodEntriesOfUser(userId,date);

            dgvFoodEntry.DataSource = foodEntries;
        }

        private void ShowFoodEntries()
        {
            foreach (MealType mealType in Enum.GetValues(typeof(MealType)))
            {
                cmbAddFoodEntry.Items.Add(new { Text = GetDescription(mealType), Value = mealType });
            }

            cmbAddFoodEntry.DisplayMember = "Text"; // Gösterilecek metin
            cmbAddFoodEntry.ValueMember = "Value";  // Arka planda tutulan değer
        }

        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute =
                (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute == null ? value.ToString() : attribute.Description;
        }




    }
}
