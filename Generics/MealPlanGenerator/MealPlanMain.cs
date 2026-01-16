using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.MealPlanGenerator
{
    /*
    4. Personalized Meal Plan Generator
o Concepts: Generic Methods, Constraints, Interfaces
o Problem Statement: Design a system where users can choose
different meal categories like Vegetarian, Vegan, Keto, or
High-Protein.
o Hints:
▪ Define an interface IMealPlan with subtypes
(VegetarianMeal, VeganMeal).
▪ Implement a generic class Meal<T> where T : IMealPlan.
▪ Use a generic method to validate and generate meal plans
dynamically.
    */
    public class MealPlanMain
    {
        public static void Execute()
        {
            Meal<VegetarianMeal> vegMeals = new Meal<VegetarianMeal>();
            vegMeals.AddMeal(new VegetarianMeal());

            Meal<VeganMeal> veganMeals = new Meal<VeganMeal>();
            veganMeals.AddMeal(new VeganMeal());

            // System.Console.WriteLine("Displaying vegetarian Meals: ");
            // vegMeals.Display();
            // System.Console.WriteLine("\nDisplaying vegan Meals:");
            // veganMeals.Display();

            System.Console.WriteLine("\nGenerating Meal Plan...");
            MealGenerator.GenerateMealPlan(new VegetarianMeal());
            MealGenerator.GenerateMealPlan(new VeganMeal());

        }
    }
}