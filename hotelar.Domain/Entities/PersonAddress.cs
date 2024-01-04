namespace hotelar.Domain.Entities
{
    public class PersonAddress : BaseClass
    {
        public PersonAddress()
        {
            People = new HashSet<Person>();
        }
        public string ? ProvinceName { get; set; }
        public string ? SquareName { get; set; }
        public string ? NeighborNamr { get; set; }
        public string ? StreetName { get; set; }
        public string ? HouNumber { get; set; }

        public ICollection<Person>? People {get; set;}
    }
}