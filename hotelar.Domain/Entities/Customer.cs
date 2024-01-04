namespace hotelar.Domain.Entities
{
    public class Customer : BaseClass
    {
        public bool IsHosted { get; set; }
        public int PersonId {get; set;}
        public virtual Person? Person {get; set;}
    }
}