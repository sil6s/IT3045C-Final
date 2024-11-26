
namespace IT3045C_Final.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string PetType { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
