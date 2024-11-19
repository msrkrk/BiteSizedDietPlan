using AutoMapper;
using BiteSizedDietPlan.MappingProfile;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.ConcreteServices;
using BiteSizedDietPlan_BLL.MappingProfile;
using BiteSizedDietPlan_DAL.ConcreteRepositories;
using BiteSizedDietPlan_DAL.Context;
using BiteSizedDietPlan_DAL.Entities;

namespace BiteSizedDietPlan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfileDto());
                cfg.AddProfile(new MappingProfileModel());
            });

            IMapper mapper = new Mapper(mapperConfig);

            var context = new AppDbContext();
            var userGenericRepository = new GenericRepository<User>(context);
            var userRepository = new UserRepository<User>(context); 
            var userService = new UserService(userGenericRepository, mapper,userRepository);
            var hashService = new HashService();
            Application.Run(new LoginForm(userService, mapper,hashService));
        }
    }
}