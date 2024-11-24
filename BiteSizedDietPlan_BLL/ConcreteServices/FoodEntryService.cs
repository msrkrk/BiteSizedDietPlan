using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_BLL.Dtos.ReportsDto;
using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.ConcreteServices
{
    public class FoodEntryService : IFoodEntryService
    {
        private readonly IFoodEntryRepository _foodEntryRepository;
        private readonly IMapper _mapper;
        private readonly IFoodEntryMealRepository _foodEntryMealRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMealRepository _mealRepository;


        public FoodEntryService(IFoodEntryRepository foodEntryRepository, IMapper mapper, IFoodEntryMealRepository foodEntryMealRepository, IUserRepository userRepository, IMealRepository mealRepository)
        {
            _foodEntryRepository = foodEntryRepository;
            _mapper = mapper;
            _foodEntryMealRepository = foodEntryMealRepository;
            _userRepository = userRepository;
            _mealRepository = mealRepository;
        }

        public int AddFoodEntry(FoodEntryDto foodEntryDto)
        {
            return _foodEntryRepository.Add(_mapper.Map<FoodEntry>(foodEntryDto));
        }

        public void AddFoodEntryMeal(FoodEntryMealDto foodEntryMealDto)
        {
            _foodEntryMealRepository.Add(_mapper.Map<FoodEntryMeal>(foodEntryMealDto));
        }

        public void DeleteFoodEntry(int id)
        {
            _foodEntryRepository.Delete(id);
        }

        public void DeleteFoodEntryMeal(int id)
        {
            _foodEntryMealRepository.Delete(id);
        }

        public List<FoodEntryDto> GetDailyFoodEntriesOfUser(int userId, DateTime date)
        {
            var foodEntries = _foodEntryRepository.GetAll(x=> x.UserId == userId && x.Date.Date == date.Date);

            return foodEntries.Select(x=>_mapper.Map<FoodEntryDto>(x)).ToList();
        }

        public List<FoodEntryMealDto> GetFoodEntryMeals(int foodEntryId)
        {
            var foodEntryMeals = _foodEntryMealRepository.GetAll(x => x.FoodEntryId == foodEntryId);

            return foodEntryMeals.Select(x => _mapper.Map<FoodEntryMealDto>(x)).ToList();
        }

        public List<GeneralCalorieReportDto> GetGeneralCalorieReportData(DateTime startDate, DateTime endDate)
        {
            return _userRepository.GetUsersWithFoodEntries(startDate,endDate).Select(x=>_mapper.Map<GeneralCalorieReportDto>(x)).ToList();
        }

        public List<MealConsumptionReportDto> GetMealConsumptionReportData(DateTime startDate, DateTime endDate)
        {
            return _mealRepository.GetMealsWithFoodEntries(startDate,endDate).Select(x=>_mapper.Map<MealConsumptionReportDto>(x)).ToList(); 
        }

        public void UpdateFoodEntryMeal(FoodEntryMealDto foodEntryMealDto)
        {
            _foodEntryMealRepository.Update(_mapper.Map<FoodEntryMeal>(foodEntryMealDto));
        }
    }
}
