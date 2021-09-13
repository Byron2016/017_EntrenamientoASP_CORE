using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Controllers
{
    public class DepartmentsController : Controller
    {
        public string Index()
        {
            return "List() de DepartamentsController";
        }

        public string Details()
        {
            return "Details() de DepartamentsController";
        }
    }
}
