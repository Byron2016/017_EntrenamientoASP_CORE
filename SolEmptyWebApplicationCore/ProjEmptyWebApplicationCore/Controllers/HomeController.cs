using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            //return "Hello from MVC";
            return Json(new { id= 1, name = "Trump" });
        }
    }
}
