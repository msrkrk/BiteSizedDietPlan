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
    public class MealService : IMealService
    {
        private readonly IGenericRepository<Meal> _genericRepository;
        private readonly IMapper _mapper;

        public MealService(IGenericRepository<Meal> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public List<MealDto> GetMeals()
        {
           var meals = _genericRepository.GetAll();

            return _mapper.Map<List<MealDto>>(meals);
        }
    }
}
