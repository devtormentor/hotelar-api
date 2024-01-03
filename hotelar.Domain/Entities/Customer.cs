using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Customer : BaseClass
    {
        public string CustomerName { get; set; } 
        public string CustomerServiceRequest { get; set; } 
    }
}