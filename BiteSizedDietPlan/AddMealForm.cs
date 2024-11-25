using AutoMapper;
using BiteSizedDietPlan.Models.MealViewModels;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;
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
        private readonly IFoodEntryService _foodEntryService;
        private readonly UserViewModel _userViewModel;


        public AddMealForm(IMapper mapper, IMealService mealService, UserViewModel userViewModel, IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _mapper = mapper;
            _mealService = mealService;
            _userViewModel = userViewModel;
            _foodEntryService = foodEntryService;
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
            var category = (MealCategoryDto)cmbMealCategory.SelectedItem;
            var meal = new MealViewModel()
            {
                Name = txtMealName.Text,
                Calorie = Convert.ToInt32(txtCalorie.Text),
                MealCategoryId =category.Id,
                ImagePath = SaveImage(_imagePath),
            };

            _mealService.AddMeal(_mapper.Map<MealDto>(meal));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form form = new HomePageForm(_mapper,_mealService,_userViewModel,_foodEntryService);
            this.Close();
            form.ShowDialog();
        }
    }
}
