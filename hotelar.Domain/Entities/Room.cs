namespace hotelar.Domain.Entities;

public class Room : BaseClass
{
    public Room()
    {
        Reservations = new HashSet<Reservation>();
        DirectSells = new HashSet<DirectSell>();
    }
    public string ? RoomType { get; set; }
    public string ? RoomNumber { get; set; }
    public ICollection<Reservation> ? Reservations {get; set;}
    public ICollection<DirectSell> ? DirectSells {get; set;}
}