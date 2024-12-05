using System.Linq;
using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class PetSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Pets.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var pets = new[]
            {
                new Pet
                {
                    PetType = "None",
                    Name = null,
                    Age = null,
                    Color = null,
                    Gender = null,
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id)
                },
                new Pet
                {
                    PetType = "None",
                    Name = null,
                    Age = null,
                    Color = null,
                    Gender = null,
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id)
                },
                new Pet
                {
                    PetType = "Dog",
                    Name = "Wilson",
                    Age = "4 years",
                    Color = "Black and Brown",
                    Gender = "Male",
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id)
                }
            };

            context.Pets.AddRange(pets);
            context.SaveChanges();
        }
    }
}
