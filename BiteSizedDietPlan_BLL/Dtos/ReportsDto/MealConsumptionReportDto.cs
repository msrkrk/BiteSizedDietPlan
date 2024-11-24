using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.ReportsDto
{
    public class MealConsumptionReportDto
    {
        public string Meal { get; set; }

        public int DinnerPortion { get; set; }
        public int LunchPortion { get; set; }
        public int BreakfastPortion { get; set; }
        public int SnacksPortion { get; set; }
        public int TotalPortion => DinnerPortion + LunchPortion + BreakfastPortion + SnacksPortion;
    }
}
