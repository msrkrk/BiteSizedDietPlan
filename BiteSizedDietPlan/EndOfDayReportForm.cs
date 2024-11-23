using AutoMapper;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.Entities;
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
    public partial class EndOfDayReportForm : Form
    {
        private readonly IFoodEntryService _foodEntryService;
        private readonly IMapper _mapper;
        private readonly UserViewModel _user;


        public EndOfDayReportForm(IMapper mapper, IFoodEntryService foodEntryService, UserViewModel user)
        {
            InitializeComponent();
            _mapper = mapper;
            _foodEntryService = foodEntryService;
            _user = user;
            LoadData();
            
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            lstvFoodEntries.Clear();
            lstvFoodEntries.ShowGroups = true;
            lstvFoodEntries.View = View.Details;
            lstvFoodEntries.GridLines = true;
            var date = dateTimePicker.Value;
            var userId = _user.Id;


            lstvFoodEntries.Columns.Add("Yemek",200);
            lstvFoodEntries.Columns.Add("Porsiyon", 200);
            lstvFoodEntries.Columns.Add("Kalori", 200);
           
            
            var foodEntries = _foodEntryService.GetDailyFoodEntriesOfUser(userId, date);

            foreach( var foodEntry in foodEntries)
            {
                var group = new ListViewGroup(Helpers.GetEnumDescription(foodEntry.MealType),HorizontalAlignment.Left);
                lstvFoodEntries.Groups.Add(group);

                foreach(var meal in foodEntry.FoodEntryMeals)
                {
                    var listViewItem = new ListViewItem(new[] {meal.Meal.Name,meal.Portion.ToString(),meal.Calorie.ToString()},group);

                    lstvFoodEntries.Items.Add(listViewItem);

                }

                

            }


            var totalCalorie = foodEntries.Sum(meal => meal.Calorie);

            txtTotalCalorie.Text = totalCalorie.ToString();
        }
    }
}
