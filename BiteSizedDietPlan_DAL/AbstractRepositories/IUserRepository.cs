﻿using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.AbstractRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetUserByEmail(string email);

        List<User> GetUsersWithFoodEntries(DateTime start, DateTime end);

    }
}
