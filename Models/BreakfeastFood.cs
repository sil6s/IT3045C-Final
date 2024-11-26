namespace IT3045C_Final.Models
{
    public class BreakfastFood
    {
        public int Id { get; set; }
        public string BreakfastYN { get; set; }
        public string Drink { get; set; }
        public string Protein { get; set; }
        public string Carbs { get; set; }
        public string FruitsOrVeggies { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}