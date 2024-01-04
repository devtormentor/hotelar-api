namespace hotelar.Domain.Entities
{
    public class DirectSell : BaseClass
    {
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public int RoomServiceId { get; set; }
        public decimal Value { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut {get; set;}
        public Customer? Customer { get; set; }
        public RoomService? RoomService { get; set; }
        public Room? Room { get; set; } 
    }
}