using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.AbstractServices
{
    public interface IHashService
    {
        string GetHashCode(string password);
    }
}
