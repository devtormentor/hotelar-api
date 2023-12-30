using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.Entities
{
    public class Employee : BaseClass
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } 
        public string EmployeeFunction { get; set; } 
        public string EmployeeLevel { get; set; } 
        


    }
}