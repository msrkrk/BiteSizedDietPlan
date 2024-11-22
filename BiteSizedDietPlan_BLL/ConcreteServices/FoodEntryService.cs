using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
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
        private readonly IGenericRepository<FoodEntry> _foodEntryRepository;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<FoodEntryMeal> _foodEntryMealRepository;
        private readonly FoodEntryDto _foodEntryDto;

        public FoodEntryService(IGenericRepository<FoodEntry> foodEntryRepository, IMapper mapper, IGenericRepository<FoodEntryMeal> foodEntryMealRepository)
        {
            _foodEntryRepository = foodEntryRepository;
            _mapper = mapper;
            _foodEntryMealRepository = foodEntryMealRepository;
        }

        public void AddFoodEntry(FoodEntryDto foodEntryDto)
        {
            _foodEntryRepository.Add(_mapper.Map<FoodEntry>(foodEntryDto));
        }

        public void AddFoodEntryMeal(FoodEntryMealDto foodEntryMealDto)
        {
            _foodEntryMealRepository.Add(_mapper.Map<FoodEntryMeal>(foodEntryMealDto));
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

        public void UpdateFoodEntryMeal(FoodEntryMealDto foodEntryMealDto)
        {
            _foodEntryMealRepository.Update(_mapper.Map<FoodEntryMeal>(foodEntryMealDto));
        }
    }
}
