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
        private readonly IGenericRepository<FoodEntry> _genericRepository;
        private readonly IMapper _mapper;

        public FoodEntryService(IGenericRepository<FoodEntry> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public List<FoodEntryDto> GetDailyFoodEntriesOfUser(int userId, DateTime date)
        {
            var foodEntries = _genericRepository.GetAll(x=> x.UserId == userId && x.Date.Date == date.Date);

            return foodEntries.Select(x=>_mapper.Map<FoodEntryDto>(x)).ToList();
        }
    }
}
