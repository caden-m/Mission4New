using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, ApplicationContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Application()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Application(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                return View(ar);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
