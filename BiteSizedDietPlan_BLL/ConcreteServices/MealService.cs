using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.ConcreteRepositories;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.ConcreteServices
{
    public class MealService : IMealService
    {
        private readonly IGenericRepository<Meal> _genericRepository;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<MealCategory> _categoryRepository;

        public MealService(IGenericRepository<Meal> genericRepository, IMapper mapper, IGenericRepository<MealCategory> categoryRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public void AddMeal(MealDto meal)
        {
            _genericRepository.Add(_mapper.Map<Meal>(meal));
        }

        public List<MealDto> GetMeals()
        {
           var meals = _genericRepository.GetAll();

            return _mapper.Map<List<MealDto>>(meals);
        }

        public List<MealCategoryDto> GetMealsCategory()
        {
            var mealCategories = _categoryRepository.GetAll();
            return _mapper.Map<List<MealCategoryDto>>(mealCategories);
        }
    }
}
