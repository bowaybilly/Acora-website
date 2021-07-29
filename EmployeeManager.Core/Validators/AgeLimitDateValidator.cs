using System;

namespace EmployeeManager.Core
{
    public class AgeLimitDateValidator: System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public override bool IsValid(object value)
        {
             
            var givenDate = (DateTime)value;
            var ageOfPerson = DateTime.Now.Year-givenDate.Year;
            if (ageOfPerson>=18 && ageOfPerson<=65)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
