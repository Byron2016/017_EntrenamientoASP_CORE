using Microsoft.AspNetCore.Mvc;
using ProjEmptyWebApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        public string Index()
        {
            //return "Hello from MVC";
            return _employeeRepository.GetEmployee(1).Name;
            //return Json(new { id= 1, name = "Trump" });
        }
    }
}
