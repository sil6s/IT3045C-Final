namespace IT3045C_Final.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public required string CollegeProgram { get; set; }
        public required string YearInProgram { get; set; }
        
        // Make these properties optional (nullable)
        public List<BreakfastFood>? BreakfastFoods { get; set; }
        public List<Hobby>? Hobbies { get; set; }
        public List<Pet>? Pets { get; set; }
    }
}
