using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Food
    {
        public Meal meal { get; set; }
        public decimal cost { get; set; }
        public Drink drink { get; set; }
        public string Name { get; set; }

        public enum Meal
        {
            Breakfast,
            Lunch,
            Dinner,
            NotAMeal
        }
        public enum Drink
        {
            Alcoholic,
            NonAlcholic
        }
    }
}
