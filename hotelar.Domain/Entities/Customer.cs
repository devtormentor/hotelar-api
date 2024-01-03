using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Customer : Person
    {
        public bool IsGuest { get; set; }
    }
}