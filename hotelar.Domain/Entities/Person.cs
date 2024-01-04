namespace hotelar.Domain.Entities
{
    public class Person : BaseClass
    {
        public Person()
        {
            Customers = new HashSet<Customer>();
        }
        public string ?  DocIdtype { get; set; }
        public string ?  DocIdNumber { get; set; }
        public string ?  FullName { get; set; }
        public DateTime  BirthDate { get; set; }
        public int AddressId {get; set;}
        public int ContactId {get; set;}
        public ICollection<Customer>? Customers {get; set;}
        public virtual PersonAddress? Address {get; set;}
        public virtual PersonContact? PersonContact {get; set;}
    }
}