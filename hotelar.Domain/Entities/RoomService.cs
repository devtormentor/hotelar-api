namespace hotelar.Domain.Entities;

public class RoomService : BaseClass
{
    public RoomService()
    {
        Reservations = new HashSet<Reservation>();
        DirectSells = new HashSet<DirectSell>();
    }
    public decimal ServicePrice { get; set; }
    public string? ServiceName { get; set; }
    public ICollection<Reservation> Reservations {get; set;}
    public ICollection<DirectSell> DirectSells {get; set;}
}