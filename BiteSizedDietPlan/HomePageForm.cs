using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiteSizedDietPlan
{
    public partial class HomePageForm : Form
    {
        private readonly IMapper _mapper;
        private readonly IMealService _mealService;

        public HomePageForm(IMapper mapper,IMealService mealService)
        {
            InitializeComponent();
            _mapper = mapper;
            _mealService = mealService;
            LoadMeals();
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








    }
}
