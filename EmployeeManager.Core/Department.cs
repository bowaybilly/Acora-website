using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Core
{
    public class Department
    {
        [Key()]
        public Guid Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        
    }
}
