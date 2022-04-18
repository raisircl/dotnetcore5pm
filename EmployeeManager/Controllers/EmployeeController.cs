using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
namespace EmployeeManager.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            List<Employee> employees = employeeRepository.GetEmployees();
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            Employee e1 = employeeRepository.GetEmployee(id);
            return View(e1);
        }

    }
}
