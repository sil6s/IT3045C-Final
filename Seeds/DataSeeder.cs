using IT3045C_Final.Data;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Seeds
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.TeamMembers.Any())
            {
                TeamMemberSeeder.Seed(context);
            }

            if (!context.BreakfastFood.Any())
            {
                BreakfastFoodSeeder.Seed(context);
            }

            if (!context.Hobbies.Any())
            {
                HobbySeeder.Seed(context);
            }

            if (!context.Pets.Any())
            {
                PetSeeder.Seed(context);
            }

            context.SaveChanges();
        }
    }
}
