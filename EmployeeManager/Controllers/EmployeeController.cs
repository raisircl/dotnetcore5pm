using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
using EmployeeManager.ViewModels;
namespace EmployeeManager.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [Route("empdetails")]
        public IActionResult Index()
        {

            //List<Employee> employees = employeeRepository.GetEmployees();
            EmployeeViewModel model = new EmployeeViewModel()
            {
                PageTitle = "Employee List",
                Employees = employeeRepository.GetEmployees()
        };

            //ViewData["Title"] = "Employees List";
            //ViewData["Employees"] = employees;
            //return View("/MyViews/manjeet.cshtml");
            return View(model);
        }
        
        public IActionResult Details(int id)
        {
            Employee e1 = employeeRepository.GetEmployee(id);
            return View(e1);
        }

    }
}
