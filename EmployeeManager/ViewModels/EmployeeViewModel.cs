using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
namespace EmployeeManager.ViewModels
{
    public class EmployeeViewModel
    {
        public string PageTitle { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
