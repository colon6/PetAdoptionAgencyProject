namespace PetAdoptionAgencyProject.Models.Entities
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Size { get; set; }
        public int AdoptionFee {  get; set; }
        public bool ChildFriendly { get; set; }
        public bool AnimalFriendly { get; set; }
        public bool Bonded {  get; set; }
    }
}
