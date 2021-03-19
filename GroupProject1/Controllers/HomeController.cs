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
        private GroupListContext _context;

        public HomeController(ILogger<HomeController> logger, IGroupRepo repository, GroupListContext context)
        {
            _logger = logger;
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignupView()
        {
            // return timeslots that have not been booked
            return View(new TimeslotList
            {
                Times = _repository.Times
                    .Where(t => t.isBooked == false)
                    .OrderBy(t => t.Date)
            });
        }

        [HttpPost]
        public IActionResult SignupView(string date)
        {
            TempData["Date"] = date;
            // store the date to pass to the signup form
            return RedirectToAction("SignupForm");
        }

        [HttpGet]
        public IActionResult SignupForm()
        {
            // grab the temp data and move it into the view data
            ViewData["Date"] = TempData["Date"];
            return View();
        }

        [HttpPost]
        public IActionResult SignupForm(Group response)
        {
            // add a group and set the time to booked if valid
            if (ModelState.IsValid)
            {                
                _context.Groups.Add(response);

                var data = _context.Times.Where(t => t.Date == response.Date).SingleOrDefault();
                data.isBooked = true;

                _context.SaveChanges();
            }
            return View("SignupView", new TimeslotList
            {
                Times = _repository.Times
                    .Where(t => t.isBooked == false)
                    .OrderBy(t => t.Date)
            });
        }

        public IActionResult ViewAppointments()
        {
            return View(_context.Groups);
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
