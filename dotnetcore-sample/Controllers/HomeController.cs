using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;

namespace dotnetcore_sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestContext _context;
        public HomeController(TestContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var s = _context.Configs.First();
            
            ViewData["Message"] = $"Your application description page - Adam Testing from {s.Value}.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
