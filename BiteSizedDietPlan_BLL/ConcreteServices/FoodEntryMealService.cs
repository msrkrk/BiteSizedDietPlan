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
    public class FoodEntryMealService : IFoodEntryMealService
    {
        private readonly IGenericRepository<FoodEntryMeal> _genericRepository;
        private readonly IMapper _mapper;

        public FoodEntryMealService(IGenericRepository<FoodEntryMeal> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
       
    }
}
