using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Employee Name is Required")]
        [MinLength(length:8)]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
       [Required]
        public Department? Department { get; set; }
    }
}
