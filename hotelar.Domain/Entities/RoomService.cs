using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class RoomService : BaseClass
    {
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public IEnumerable<ServiceScheduling> Scheduling { get; set;}
        public IEnumerable<DailySells> DailySells { get; set;}
    }
}