using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class HobbySeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var teamMember = context.TeamMembers.FirstOrDefault();
            if (teamMember == null || context.Hobbies.Any()) return;

            var hobby = new Hobby
            {
                HobbyYN = "Yes",
                Artistic = "Painting",
                Athletic = "Soccer",
                Musical = "Guitar",
                Academic = "Reading",
                TeamMemberId = teamMember.Id
            };

            context.Hobbies.Add(hobby);
            context.SaveChanges();
        }
    }
}
