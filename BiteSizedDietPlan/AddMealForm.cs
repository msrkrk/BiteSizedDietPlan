using AutoMapper;
using BiteSizedDietPlan.Models.MealViewModels;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.ConcreteServices;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
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
    public partial class AddMealForm : Form
    {
        private string _imagePath;
        private readonly IMapper _mapper;
        private readonly IMealService _mealService;

        public AddMealForm(IMapper mapper, IMealService mealService)
        {
            InitializeComponent();
            _mapper = mapper;
            _mealService = mealService;
            ShowMealCategories();
        }

        private void ShowMealCategories()
        {
            cmbMealCategory.Items.Clear();
            cmbMealCategory.Items.Add("Seçiniz");
            cmbMealCategory.Items.AddRange(_mealService.GetMealsCategory().ToArray());
            cmbMealCategory.SelectedIndex = 0;
        }

        private void pictureBoxMeal_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFileDialog.FileName;
                    pictureBoxMeal.ImageLocation = _imagePath;
                }
            }
        }

        private string SaveImage(string sourcePath)
        {
            string projectPath = Directory.GetParent((AppDomain.CurrentDomain.BaseDirectory)).Parent.Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Images");
            Directory.CreateDirectory(imagePath);
            string fileName = Path.GetFileName(sourcePath);
            string destinationPath = Path.Combine(imagePath, fileName);
            File.Copy(sourcePath, destinationPath, true);
            return destinationPath;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
              
                var category = (MealCategoryDto)cmbMealCategory.SelectedItem;
                if (category == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int calorie;
                if (!int.TryParse(txtCalorie.Text, out calorie) || calorie < 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kalori değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string imagePath;
                try
                {
                    imagePath = SaveImage(_imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Resim kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var meal = new MealViewModel()
                {
                    Name = txtMealName.Text,
                    Calorie = calorie,
                    MealCategoryId = category.Id,
                    ImagePath = imagePath,
                };

                if (string.IsNullOrWhiteSpace(meal.Name) || string.IsNullOrWhiteSpace(meal.ImagePath))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _mealService.AddMeal(_mapper.Map<MealDto>(meal));
                    MessageBox.Show("Yemek başarı ile eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Yemek eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


