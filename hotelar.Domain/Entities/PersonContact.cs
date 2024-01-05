namespace hotelar.Domain.Entities
{
    public class PersonContact : BaseClass
    {
        public string ?  FaxNumber { get; set; }
        public string ?  ModileNumber { get; set; }
        public string ?  PhoneNumber { get; set; }
        public string ?  EmailAddress { get; set; }
        public virtual Person ? Person {get; set;}
    }
}