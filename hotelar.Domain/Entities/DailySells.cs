using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class DailySells : BaseClass
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public decimal PaidValue { get; set; }

        public virtual Customer Customer {get; set;}
        public virtual Employee Employee {get; set;}
        public IEnumerable<RoomService> RoomServices {get; set;}
        public IEnumerable<Room> Rooms{get; set;}
    }
}