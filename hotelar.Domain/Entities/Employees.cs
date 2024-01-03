using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Employee : Person
    {
        public string EmployeeFunction { get; set; } 
        public string EmployeeLevel { get; set; } 
        public DateTime AdmissionDate { get; set; }
    }
}