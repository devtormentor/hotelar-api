namespace hotelar.Domain.Entities
{
    public class ServiceScheduling : BaseClass
    {
        public int RoomId {get; set;}
        public int CustomerId {get; set;}
        public int ServiceId {get; set;}
        public virtual Room Room { get; set;}
        public virtual Customer Customer { get; set;}
        public virtual RoomService Service {get; set;}        
    }
}