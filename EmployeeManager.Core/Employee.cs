using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Core
{
    public class Employee
    {
        [Key()]
        public int EmployeeNumber { get; set; }
        [Required(ErrorMessage ="Date of birth is required")]
        [AgeLimitDateValidator(ErrorMessage ="Employee age must between 18 and 65")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage ="Please select employee")]
        public Guid Department { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }

    }
}
