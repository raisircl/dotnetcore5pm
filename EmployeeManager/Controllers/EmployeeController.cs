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
        //[Route("empdetails")]
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

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Title = "Create Employee";
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = employeeRepository.SaveEmployee(employee);
                //return RedirectToAction("Details", new { id = newEmployee.Id });
            }
            return View();
        }
        public string MyInfo(int? id, string name, string dept)
        {
            return $"My Detai is Id={id} , Name={name} and Department={dept}";
        }
        public IActionResult Details(int id)
        {
            Employee e1 = employeeRepository.GetEmployee(id);
            
            List<Employee> e = new List<Employee>();
            e.Add(e1);

            EmployeeViewModel model = new EmployeeViewModel()
            {
                PageTitle = "Employee Detail",
                Employees = e
            };


            return View(model);
        }

    }
}
