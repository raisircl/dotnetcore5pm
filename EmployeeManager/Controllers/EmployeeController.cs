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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            Employee e1 = new Employee() { Id = 1001, Name = "Manjeet", Department = ".Net" };

            return View(e1);
        }

    }
}
