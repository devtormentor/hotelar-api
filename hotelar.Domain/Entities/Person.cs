using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Person : BaseClass
    {
        public string  DocIdtype { get; set; }
        public string  DocIdNumber { get; set; }
        public string  FullName { get; set; }
        public DateTime  BirthDate { get; set; }
    }
}