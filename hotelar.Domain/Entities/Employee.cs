namespace hotelar.Domain.Entities
{
    public class Employee : BaseClass
    {
        public Employee()
        {
            Sells = new HashSet<DirectSell>();
            Reservations = new HashSet<Reservation>();
        }
        public bool IsHosted { get; set; }
        public int PersonId {get; set;}
        public virtual Person? Person {get; set;}
        public ICollection<DirectSell> ? Sells {get; set;}
        public ICollection<Reservation> ? Reservations {get; set;}
    }
}