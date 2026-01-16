using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.MealPlanGenerator
{
    // subclass
    public class VegetarianMeal : IMealPlan
    {
        public string Name = "Vegetarian Meal";
        public int NoOfCalories = 350;

        public void DisplayMeal()
        {
            System.Console.WriteLine($"{Name} | Calories in meal: {NoOfCalories}");
        }

    }
}