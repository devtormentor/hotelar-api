namespace hotelar.Domain.Entities
{
    public class ServiceScheduling : BaseClass
    {
        public decimal Value { get; set; }
        public int RoomServiceId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Room Room { get; set;}
        public virtual Customer Customer { get; set;}
        public IEnumerable<RoomService> Service {get; set;}        
    }
}