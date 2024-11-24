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
    public partial class GeneralCalorieReportForm : Form
    {
        private readonly IFoodEntryService _foodEntryService;

        public GeneralCalorieReportForm(IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _foodEntryService = foodEntryService;
            LoadReportData();
        }

        void LoadReportData()
        {
            var datas = _foodEntryService.GetGeneralCalorieReportData();

            dgvGeneralCalorieReport.DataSource = datas;
        }
    }
}
