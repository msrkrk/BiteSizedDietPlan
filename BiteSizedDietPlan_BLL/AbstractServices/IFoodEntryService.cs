using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.AbstractServices
{
    public interface IFoodEntryService
    {
        List<FoodEntryDto> GetDailyFoodEntriesOfUser(int userId, DateTime date);

        int AddFoodEntry(FoodEntryDto foodEntryDto);

        List<FoodEntryMealDto> GetFoodEntryMeals(int foodEntryId);

        void AddFoodEntryMeal(FoodEntryMealDto foodEntryMealDto);

        void UpdateFoodEntryMeal(FoodEntryMealDto foodEntryMealDto);

        void DeleteFoodEntryMeal(int id);

        void DeleteFoodEntry(int id);
    }
}
