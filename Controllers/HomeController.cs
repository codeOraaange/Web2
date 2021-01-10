using System;
using Microsoft.AspNetCore.Mvc;

namespace WebSukaSuka.controllers
{
    public class HomeController : Controller  
    {
        public IActionResult Index(){;
            return View(); 
        }
    }
}