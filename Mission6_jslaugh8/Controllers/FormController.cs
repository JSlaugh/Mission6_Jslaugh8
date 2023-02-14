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

        private MovieContext _formContext { get; set; }
        public FormController(ILogger<FormController> logger,MovieContext movieContext )
        {
            _logger = logger;
            _formContext = movieContext;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Index(FormResponse ar) 
        {

            if (ModelState.IsValid)
            {
                _formContext.Add(ar);
                _formContext.SaveChanges();
                return View("Confirmation",ar);
            }
            else
            {
            return View();
            }
        }
    }



}
