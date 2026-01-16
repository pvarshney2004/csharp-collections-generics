using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.MealPlanGenerator
{
    // generic class
    public class Meal<T> where T : IMealPlan
    {
        private List<T> meals = new List<T>(); // list to store diffrent type of meal

        public void AddMeal(T meal)
        {
            meals.Add(meal);
        }
        public List<T> GetAllMeals()
        {
            return meals;
        }
        // method to display meals
        public void Display()
        {
            foreach(T meal in meals)
            {
                meal.DisplayMeal(); // demonstrating polymorphism
            }
        }
    }
}