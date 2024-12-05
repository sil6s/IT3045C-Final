using System.Linq;
using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class BreakfastFoodSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.BreakfastFood.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var breakfastFoods = new[]
            {
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Orange Juice",
                    Protein = "Sausage Links",
                    Carbs = "Pancakes",
                    FruitsOrVeggies = null,
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id)
                },
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Coffee",
                    Protein = "Bacon",
                    Carbs = "Pancakes",
                    FruitsOrVeggies = null,
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id)
                },
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Milk",
                    Protein = "Eggs",
                    Carbs = "Toast",
                    FruitsOrVeggies = "Apple",
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id)
                }
            };

            context.BreakfastFood.AddRange(breakfastFoods);
            context.SaveChanges();
        }
    }
}
