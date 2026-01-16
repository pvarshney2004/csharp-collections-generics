using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.MealPlanGenerator
{
    public class MealGenerator
    {
        // generic method to generate meal plan dynamically for diffrent type of meals
        public static void GenerateMealPlan<T>(T meal)
            where T : IMealPlan
        {
            meal.DisplayMeal();
        }
    }
}