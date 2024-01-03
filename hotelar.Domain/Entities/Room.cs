using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Room : BaseClass
    {
        public string RoomType { get; set; }
        public int DoorNumber { get; set; }
        public bool IsAvailable { get; set; }        
    }
}