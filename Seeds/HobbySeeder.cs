using IT3045_Final.Data;
using IT3045_Final.Models;

namespace IT3045_Final.Seeds 
{
    public static class HobbySeeder
    {
        public static void Seed(ApplicationDbContext context) 
        {
            var teamMember = context.TeamMembers.FirstOrDefault();
            var hobby = new Hobby 
            {
                Artistic = "Painting"
                Athletic = "Soccer"
                Musical = "Guitar"
                Academic = "Reading"
                TeamMemberId = teamMember.Id
            };
            context.Hobby.Add(hobby)
            context.SaveChanges();
        }
    }
}