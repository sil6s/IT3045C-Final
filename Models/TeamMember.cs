namespace IT3045C_Final.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public string YearInProgram { get; set; }
        public List<BreakfastFood> BreakfastFoods { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public List<Pet> Pets { get; set; }
    }
}