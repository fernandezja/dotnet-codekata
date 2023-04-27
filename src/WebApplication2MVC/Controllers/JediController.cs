using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2MVC.Entities;
using WebApplication2MVC.Models;

namespace WebApplication2MVC.Controllers
{
    public class JediController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public JediController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            var jedi = new Jedi() { 
                Id = 1,
                Name = "Yoda"
            };

            return View(jedi);
        }
    }
}