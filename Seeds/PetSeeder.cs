using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class PetSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var teamMember = context.TeamMembers.FirstOrDefault();
            var pet = new Pet
            {
                PetType = "Dog",
                Name = "Buddy",
                Age = "2 years",
                Color = "Brown",
                Gender = "Male",
                TeamMemberId = teamMember.Id
            };
            context.Pets.Add(pet);
            context.SaveChanges();
        }
    }
}
