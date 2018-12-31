using GFTTest.Models.EN;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFTTest.Models
{
    public class Dish
    {
        public ENDishType DishType { get; set; }
        public string Period { get; set; }        
        public string Name { get; set; }
        public bool Repeatable { get; set; }
    }
}
