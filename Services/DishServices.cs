using GFTTest.Models;
using GFTTest.Models.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFTTest.Services
{
    public class DishServices : IDishServices
    {
        private readonly Dictionary<int, List<Dish>> _orders;
        private readonly List<Dish> _dishes;

        public DishServices()
        {
            _orders = new Dictionary<int, List<Dish>>();
            _dishes = new List<Dish>() {
                new Dish { DishType = ENDishType.entree, Period = "morning", Name = "Eggs"},
                new Dish { DishType = ENDishType.side, Period = "morning", Name = "Toast"},
                new Dish { DishType = ENDishType.drink, Period = "morning", Name = "Coffee", Repeatable = true },
                new Dish { DishType = ENDishType.entree, Period = "night", Name = "Steak"},
                new Dish { DishType = ENDishType.side, Period = "night", Name = "Potato", Repeatable = true},
                new Dish { DishType = ENDishType.drink, Period = "night", Name = "Wine"},
                new Dish { DishType = ENDishType.dessert, Period = "night", Name = "Cake"},
            };
        }

        public Dictionary<int, List<Dish>> GetOrdersHistory()
        {
            return _orders;
        }

        public List<Dish> AddOrder(string order)
        {
            if (string.IsNullOrEmpty(order))
                throw new NullReferenceException("Invalid Order!");

            var orderSplit = order.Trim().Split(',');
            var period = orderSplit[0];
            List<Dish> dishes = new List<Dish>();

            if(period != "morning" && period != "night")
            {
                throw new InvalidOperationException("Invalid time of the day!");
            }

            for(var i = 1; i < orderSplit.Length; i++)
            {
                var dish = _dishes.Where(w => (int)w.DishType == Convert.ToInt32(orderSplit[i]) && w.Period == period).FirstOrDefault();

                if (dish == null)
                    throw new NullReferenceException("Invalid order!");

                //Check if there's already a Dish of the type specified, and if its repeatable to add on the Dishes list.
                if (!dishes.Any(a => a.DishType == dish.DishType && !dish.Repeatable))
                    dishes.Add(dish);
                else
                    throw new ArgumentException("Invalid order!");
            }

            if (dishes.Count == 0)
                throw new ArgumentException("Invalid order!");

            //Add the dishes to the orders dictionary
            _orders.Add(_orders.Count() + 1, dishes.OrderBy(o => o.DishType).ToList());

            return dishes;
        }
    }
}
