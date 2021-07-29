using EmployeeManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public class EmployeeViewModel
    {

        public int EmployeeNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Department { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}
