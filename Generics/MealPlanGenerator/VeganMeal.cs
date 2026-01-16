using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.MealPlanGenerator
{
    // subclass 
    public class VeganMeal : IMealPlan
    {
        public string Name = "Vegan Meal";
        public int NoOfCalories = 300;

        public void DisplayMeal()
        {
            System.Console.WriteLine($"{Name} | Calories in meal: {NoOfCalories}");
        }
    }
}