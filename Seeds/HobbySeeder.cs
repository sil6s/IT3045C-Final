using System.Linq;
using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class HobbySeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Hobbies.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var hobbies = new[]
            {
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Crafting",
                    Athletic = "None",
                    Musical = "Singing",
                    Academic = "Reading",
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id)
                },
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Drawing",
                    Athletic = "Weight Lifting",
                    Musical = "Trumpet",
                    Academic = "Reading",
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id)
                },
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Photography",
                    Athletic = "Running",
                    Musical = "Guitar",
                    Academic = "Coding",
                    TeamMemberId = (int)(teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id)
                }
            };

            context.Hobbies.AddRange(hobbies);
            context.SaveChanges();
        }
    }
}
