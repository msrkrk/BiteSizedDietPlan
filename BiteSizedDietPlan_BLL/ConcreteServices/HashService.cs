using BiteSizedDietPlan_BLL.AbstractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.ConcreteServices
{
    public class HashService : IHashService
    {
        public string GetHashCode(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
