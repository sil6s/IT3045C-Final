using IT3045C_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<TeamMember>? TeamMembers { get; set; }
        public DbSet<BreakfastFood>? BreakfastFood { get; set; }
        public DbSet<Hobby>? Hobbies { get; set; }
        public DbSet<Pet>? Pets { get; set; }
    }
}
