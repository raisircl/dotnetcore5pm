using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new {Id=1001, Name="Anil", Class="10th" });

        }
       
    }
}
