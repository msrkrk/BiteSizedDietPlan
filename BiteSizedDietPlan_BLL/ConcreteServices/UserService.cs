using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.ConcreteServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public UserDto Login(string email, string password)
        {
            var user = _genericRepository.GetAll().FirstOrDefault(x=>x.Email==email && x.Password==password);

            if (user != null)
            {
                return _mapper.Map<UserDto>(user);
            }
            else
            {
                return null;

            }
        }
    }
}
