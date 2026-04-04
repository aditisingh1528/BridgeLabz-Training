using System;

// Interface
interface IMealPlan
{
    void PrepareMeal();
}

// Meal Types
class VegetarianMeal : IMealPlan
{
    public void PrepareMeal()
    {
        Console.WriteLine("Preparing Vegetarian Meal");
    }
}

class VeganMeal : IMealPlan
{
    public void PrepareMeal()
    {
        Console.WriteLine("Preparing Vegan Meal");
    }
}

// Generic Meal
class Meal<T> where T : IMealPlan, new()
{
    public void GenerateMeal()
    {
        T meal = new T();
        meal.PrepareMeal();
    }
}

class Program
{
    static void Main()
    {
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>();
        veganMeal.GenerateMeal();
    }
}