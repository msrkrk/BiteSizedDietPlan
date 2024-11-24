using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.ReportsDto
{
    public class GeneralCalorieReportDto
    {
        public string User { get; set; }
        public int BreakfastCalorie { get; set; }
        public int LunchCalorie { get; set; }
        public int DinnerCalorie { get; set; }
        public int SnacksCalorie { get; set; }
        public int TotalCalorie => BreakfastCalorie+LunchCalorie+DinnerCalorie+SnacksCalorie;



    }
}
