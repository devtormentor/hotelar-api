using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Person : BaseClass
    {
        public string DocIdtype { get; set; }
        public string DocIdNumber { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
    }
}