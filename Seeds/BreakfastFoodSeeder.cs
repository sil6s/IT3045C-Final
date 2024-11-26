using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class BreakfastFoodSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var teamMember = context.TeamMembers.FirstOrDefault();
            var breakfastFood = new BreakfastFood
            {
                BreakfastYN = "Yes",
                Drink = "Coffee",
                Protein = "Eggs",
                Carbs = "Toast",
                FruitsOrVeggies = "Banana",
                TeamMemberId = teamMember.Id
            };
            context.BreakfastFood.Add(breakfastFood);
            context.SaveChanges();
        }
    }
}
