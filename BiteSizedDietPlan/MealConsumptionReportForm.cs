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
    public partial class MealConsumptionReportForm : Form
    {
        private readonly IFoodEntryService _foodEntryService;
        public MealConsumptionReportForm(IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _foodEntryService = foodEntryService;
        }

        void LoadData()
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            var datas = _foodEntryService.GetMealConsumptionReportData(startDate, endDate);

            dgvMealConsumptions.DataSource = datas;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
