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
            var userRepository = new UserRepository(context);
            var userService = new UserService(userGenericRepository, mapper, userRepository);
            var hashService = new HashService();
            var mealGenericRepository = new GenericRepository<Meal>(context);
            var mealCategoryGenericRepository = new GenericRepository<MealCategory>(context);
            var mealService = new MealService(mealGenericRepository, mapper,mealCategoryGenericRepository);
            var foodEntryRepository = new FoodEntryRepository(context);
            var foodEntryMealRepository = new FoodEntryMealRepository(context);
            var mealRepository = new MealRepository(context);
            var foodEntryService = new FoodEntryService(foodEntryRepository, mapper,foodEntryMealRepository,userRepository,mealRepository);
            Application.Run(new LoginForm(userService, mapper, hashService, mealService,foodEntryService));
        }
    }
}