using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string myString = "sample" )
        {
            return Content("The default. ID is " +myString);
        }
        public IActionResult Susan(int id)
        {
            return Content("You specified ID. ID: " + id);
        }
    }
}
