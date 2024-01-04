namespace hotelar.Domain.Entities
{
    public class Reservation : BaseClass
    {
        public int RoomId { get; set; }
        public int RoomServiceId { get; set; }
        public decimal Value { get; set; }
        public DateTime WishDate { get; set; }
        public virtual RoomService ? RoomService { get; set; }
        public virtual Customer ?  Customer {get; set;}
        public virtual Room ? Room { get; set; }        
    }
}