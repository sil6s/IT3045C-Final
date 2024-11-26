using IT3045_Final.Data;
using IT3045_Final.Models;

namespace IT3045_Final.Seeds
{
    public static class TeamMemberSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var teamMember = context.TeamMembers.FirstOrDefault();
            var teamMember = new TeamMember 
            {
                FirstName = "Jaxon"
                Last Name = "Coniglio"
                DOB = "10/22/2003"
                College Program = "Software Development"
                Program Level = "3rd Year"
            };
            context.TeamMember.Add(teamMember);
            context.SaveChanges();
        }
    }
}