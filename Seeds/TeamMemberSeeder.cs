using System;
using System.Linq;
using IT3045C_Final.Data;
using IT3045C_Final.Models;

namespace IT3045C_Final.Seeds
{
    public static class TeamMemberSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.TeamMembers.Any()) return;

            var teamMembers = new[]
            {
                new TeamMember
                {
                    FullName = "Audrey Ryser",
                    Birthdate = new DateTime(2003, 7, 23),
                    CollegeProgram = "Architecture",
                    YearInProgram = "Senior"
                },
                new TeamMember
                {
                    FullName = "Jaxon Coniglio",
                    Birthdate = new DateTime(2003, 10, 22),
                    CollegeProgram = "Software Development",
                    YearInProgram = "Junior"
                },
                new TeamMember
                {
                    FullName = "Silas Curry",
                    Birthdate = new DateTime(2005, 11, 28),
                    CollegeProgram = "Software Development",
                    YearInProgram = "Senior"
                }
            };

            context.TeamMembers.AddRange(teamMembers);
            context.SaveChanges();
        }
    }
}
