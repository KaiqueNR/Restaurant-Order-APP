using GFTTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFTTest.Services
{
    public interface IDishServices
    {
        Dictionary<int, List<Dish>> GetOrdersHistory();
        List<Dish> AddOrder(string order);
    }
}
