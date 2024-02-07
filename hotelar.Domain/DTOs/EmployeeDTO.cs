using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelar.Domain.DTOs
{
    public class EmployeeDTO
    {
        //propriedades do contacto
        public string ?  FaxNumber { get; set; }
        public string ?  MobileNumber { get; set; }
        public string ?  PhoneNumber { get; set; }
        public string ?  EmailAddress { get; set; }

        // propriedades da pessoa
        public string ?  DocIdtype { get; set; }
        public string ?  DocIdNumber { get; set; }
        public string ?  FullName { get; set; }
        public DateTime  BirthDate { get; set; }

        // propriedades do endereço da pessoa
        public string ? ProvinceName { get; set; }
        public string ? SquareName { get; set; }
        public string ? NeighborName { get; set; }
        public string ? StreetName { get; set; }
        public string ? HouseNumber { get; set; }

        // propriedades do customer
        public bool IsHosted { get; set; }
    }
}