using AutoMapper;
using BiteSizedDietPlan.Models.MealViewModels;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.ConcreteServices;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
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

        private int _selectedFoodEntryId;


        public HomePageForm(IMapper mapper, IMealService mealService, UserViewModel user, IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _mapper = mapper;
            _mealService = mealService;
            _user = user;
            _foodEntryService = foodEntryService;

            LoadMeals();
            ShowMealTypes();
            LoadFoodEntries();
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
                var btnSize = (int)(flpMeals.Width * 0.40);
                mealButton.Size = new Size(btnSize, btnSize); // Butonun boyutunu ayarla

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
                    var foodEntryMeals = dgvMeals.DataSource as List<FoodEntryMealDto>;

                    if (foodEntryMeals == null) return;

                    var existingFoodEntryMeal = foodEntryMeals.FirstOrDefault(x => x.MealId == meal.Id);

                    if (existingFoodEntryMeal != null)
                    {
                        existingFoodEntryMeal.Portion++;
                        _foodEntryService.UpdateFoodEntryMeal(_mapper.Map<FoodEntryMealDto>(existingFoodEntryMeal));
                    }
                    else
                    {
                        // Eğer yoksa, yeni bir kayıt ekle
                        FoodEntryMealViewModel foodEntryMeal = new FoodEntryMealViewModel();
                        foodEntryMeal.FoodEntryId = _selectedFoodEntryId;
                        foodEntryMeal.MealId = meal.Id;
                        foodEntryMeal.Portion = 1;
                        _foodEntryService.AddFoodEntryMeal(_mapper.Map<FoodEntryMealDto>(foodEntryMeal));
                    }

                    // Verileri yeniden yükle
                    LoadFoodEntryMeals();
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

            var foodEntries = _foodEntryService.GetDailyFoodEntriesOfUser(userId, date);

            dgvFoodEntry.DataSource = foodEntries;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            {
                deleteButton.Name = "Öğün Sil";
                deleteButton.Text = "SİL";
                deleteButton.UseColumnTextForButtonValue = true;
                int columnIndex = 6;
                if (dgvFoodEntry.Columns["Öğün Sil"] == null)
                {
                    dgvFoodEntry.Columns.Insert(columnIndex, deleteButton);
                }
            }

            dgvFoodEntry.Columns["Date"].Visible = false;
            dgvFoodEntry.Columns["User"].Visible = false;
            dgvFoodEntry.Columns["UserId"].Visible = false;
            dgvFoodEntry.Columns["CreatedDate"].Visible = false;


            if (foodEntries.Count > 0 && _selectedFoodEntryId == 0)
            {
                _selectedFoodEntryId = foodEntries[0].Id;
            }

            LoadFoodEntryMeals();
        }

        private void ShowMealTypes()
        {
            foreach (MealType mealType in Enum.GetValues(typeof(MealType)))
            {
                cmbMealType.Items.Add(new MealTypeComboBoxModel { Text = Helpers.GetEnumDescription(mealType), Value = mealType });
            }

            cmbMealType.DisplayMember = "Text"; // Gösterilecek metin
            cmbMealType.ValueMember = "Value";  // Arka planda tutulan değer
        }



        private void btnAddFoodEntryMeal_Click(object sender, EventArgs e)
        {
            var selected = cmbMealType.SelectedItem as MealTypeComboBoxModel;

            if (selected == null)
            {
                MessageBox.Show("Lütfen önce öğün tipi seçin.");
                return;
            }

            var date = dateTimePicker.Value;
            var mealType = selected.Value;
            var userId = _user.Id;

            var foodEntries = (dgvFoodEntry.DataSource as List<FoodEntryDto>)!;

            var isAlreadyAdded = foodEntries.Where(x => x.Date.Date == date.Date && x.MealType == mealType).Any();

            if (isAlreadyAdded)
            {
                MessageBox.Show($"Seçilen gün için {selected.Text} öğünü zaten mevcut.");
                return;
            }

            FoodEntryDto foodEntry = new FoodEntryDto()
            {
                Date = date.Date,
                MealType = mealType,
                UserId = userId,
            };

            _selectedFoodEntryId = _foodEntryService.AddFoodEntry(foodEntry);

            LoadFoodEntries();
        }

        private void dgvFoodEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            var foodEntry = (FoodEntryDto)dgvFoodEntry.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == dgvFoodEntry.Columns["Öğün Sil"].Index)
            {
                _foodEntryService.DeleteFoodEntry(foodEntry.Id);
                LoadFoodEntries();
                ResetFoodEnryMealDgv();

                return;
            }


            if (e.RowIndex >= 0) // Başlık hücresini kontrol etmek için
            {
                // Tıklanan satır
                DataGridViewRow selectedRow = dgvFoodEntry.Rows[e.RowIndex];

                // Satırdan veri alma
                _selectedFoodEntryId = (int)selectedRow.Cells["Id"].Value;

                LoadFoodEntryMeals();
            }

        }

        private void ResetFoodEnryMealDgv()
        {
            _selectedFoodEntryId = 0;
            dgvMeals.DataSource = new List<FoodEntryMealDto>();
        }

        private void LoadFoodEntryMeals()
        {
            if (_selectedFoodEntryId == 0) { return; }

            var foodEntries = _foodEntryService.GetFoodEntryMeals(_selectedFoodEntryId);
            dgvMeals.DataSource = foodEntries;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            {
                deleteButton.Name = "Yemek Sil";
                deleteButton.Text = "SİL";
                deleteButton.UseColumnTextForButtonValue = true;
                int columnIndex = 6;
                if (dgvMeals.Columns["Yemek Sil"] == null)
                {
                    dgvMeals.Columns.Insert(columnIndex, deleteButton);
                }
            }

            DataGridViewButtonColumn increaseButton = new DataGridViewButtonColumn();
            {
                increaseButton.Name = "Porsiyon Arttır";
                increaseButton.Text = "+";
                increaseButton.UseColumnTextForButtonValue = true;
                int columnIndex = 7;
                if (dgvMeals.Columns["Porsiyon Arttır"] == null)
                {
                    dgvMeals.Columns.Insert(columnIndex, increaseButton);
                }

            }

            DataGridViewButtonColumn decreaseButton = new DataGridViewButtonColumn();
            {
                decreaseButton.Name = "Porsiyon Azalt";
                decreaseButton.Text = "-";
                decreaseButton.UseColumnTextForButtonValue = true;
                int columnIndex = 8;
                if (dgvMeals.Columns["Porsiyon Azalt"] == null)
                {
                    dgvMeals.Columns.Insert(columnIndex, decreaseButton);
                }

            }

            dgvMeals.Columns["FoodEntryId"].Visible = false;
            dgvMeals.Columns["MealId"].Visible = false;
            dgvMeals.Columns["Id"].Visible = false;
            dgvMeals.Columns["CreatedDate"].Visible = false;

        }

        private void dgvMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var meal = (FoodEntryMealDto)dgvMeals.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == dgvMeals.Columns["Yemek Sil"].Index)
            {
                _foodEntryService.DeleteFoodEntryMeal(meal.Id);
                LoadFoodEntryMeals();
            }
            if (e.ColumnIndex == dgvMeals.Columns["Porsiyon Arttır"].Index)
            {
                meal.Portion++;
                _foodEntryService.UpdateFoodEntryMeal(meal);
                LoadFoodEntryMeals();
            }
            if (e.ColumnIndex == dgvMeals.Columns["Porsiyon Azalt"].Index)
            {
                meal.Portion--;


                if (meal.Portion == 0)
                {
                    _foodEntryService.DeleteFoodEntryMeal(meal.Id);
                }
                else
                {
                    _foodEntryService.UpdateFoodEntryMeal(meal);
                }
                LoadFoodEntryMeals();
            }

        }

        private void btnEndofDayReport_Click(object sender, EventArgs e)
        {
            Form form = new EndOfDayReportForm(_mapper, _foodEntryService, _user);
            form.ShowDialog();
        }

        private void btnComparisonReport_Click(object sender, EventArgs e)
        {
            Form form = new GeneralCalorieReportForm(_foodEntryService);
            form.ShowDialog();
        }

        private void btnMealTypeReport_Click(object sender, EventArgs e)
        {
            Form form = new MealConsumptionReportForm(_foodEntryService);
            form.ShowDialog();
        }
    }
    class MealTypeComboBoxModel
    {
        public string Text { get; set; }
        public MealType Value { get; set; }
    }
}







