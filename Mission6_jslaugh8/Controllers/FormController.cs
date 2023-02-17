using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission6_jslaugh8.Models;
using Microsoft.Extensions.Logging;

namespace Mission6_jslaugh8.Controllers
{


    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        private MovieContext _movieContext { get; set; }
        public FormController(ILogger<FormController> logger,MovieContext movieContext )
        {
            _logger = logger;
            _movieContext = movieContext;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Index(Movie ar) 
        {

            if (ModelState.IsValid)
            {
                _movieContext.Add(ar);
                _movieContext.SaveChanges();
                return View("Confirmation",ar);
            }
            else
            {
            return View();
            }
        }
    }



}
