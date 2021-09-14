﻿using Microsoft.AspNetCore.Mvc;
using ProjEmptyWebApplicationCore.Models;
using ProjEmptyWebApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }
        /*
        public JsonResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return Json(model);
        }
        */
        /*
        public ObjectResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return new ObjectResult(model);
        }
        */

        public ViewResult Details(int? Id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(Id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid) 
            { 
                Employee newEmployee = _employeeRepository.Add(employee);
                // return RedirectToAction("details", new { id = newEmployee.Id });
            }

            return View();
        }
    }
}
