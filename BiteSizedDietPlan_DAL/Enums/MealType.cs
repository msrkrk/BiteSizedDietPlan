using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Enums
{
    public enum MealType
    {
        
        [Description("Kahvaltı")]
        Breakfast = 1,
        [Description("Öğle Yemeği")]
        Lunch = 2,
        [Description("Akşam Yemeği")]
        Dinner = 3,
        [Description("Atıştırmalık")]
        Snacks = 4
    }
}
