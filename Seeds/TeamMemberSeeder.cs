using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class TeamMemberSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.TeamMembers.Any()) return;

            var teamMember = new TeamMember
            {
                FullName = "John Doe",
                Birthdate = new DateTime(1995, 5, 15),
                CollegeProgram = "Software Development",
                YearInProgram = "3rd Year"
            };

            context.TeamMembers.Add(teamMember);
            context.SaveChanges();
        }
    }
}
