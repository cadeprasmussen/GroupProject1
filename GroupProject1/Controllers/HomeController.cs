using GroupProject1.Models;
using GroupProject1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGroupRepo _repository;

        public HomeController(ILogger<HomeController> logger, IGroupRepo repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignupView()
        {
            return View(new TimeslotList
            {
                Times = _repository.Times
                    .Where(t => t.isBooked == false)
                    .OrderBy(t => t.Date)
            });
        }

        [HttpPost]
        public IActionResult SignUpView(appointment)
        {
            return View("SignUpForm");
        }

        public IActionResult ViewAppointments()
        {
            return View();
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
