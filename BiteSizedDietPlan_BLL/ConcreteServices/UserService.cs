using AutoMapper;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.ConcreteServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository<User> _userRepository;

        public UserService(IGenericRepository<User> genericRepository, IMapper mapper, IUserRepository<User> userRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public UserDto GetUserByEmail(string email)
        {
            var user = _userRepository.GetUserByEmail(email);

            if (user != null)
            {
                return _mapper.Map<UserDto>(user);
            }
            else
            {
                return null;

            }
        }

        public LoginUserDto Login(string email, string password)
        {
            var user = _genericRepository.GetAll().FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user != null)
            {
                return _mapper.Map<LoginUserDto>(user);
            }
            else
            {
                return null;

            }
        }

        public void Register(RegisterUserDto RegisterUserDto)
        {

            _genericRepository.Add(_mapper.Map<User>(RegisterUserDto));

        }


    }
}
