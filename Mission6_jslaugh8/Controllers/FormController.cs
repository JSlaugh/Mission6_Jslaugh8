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
        //Base form
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = _movieContext.Category.ToList();

            return View();
        }

        //Post on base form
        [HttpPost]

        public IActionResult Index(Movie movie) 
        {

            if (ModelState.IsValid)
            {
                _movieContext.Add(movie);
                _movieContext.SaveChanges();
                return View("Confirmation", movie);
            }
            else
            {
            return View(movie);
            }
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _movieContext.Category.ToList();


           var movie = _movieContext.Movies.Single(movie=> movie.MovieId == movieid);
            //Send them to base form
            return View("Index",movie);
        }

        [HttpPost]

        public IActionResult Edit(Movie movie)
        {

                _movieContext.Update(movie);
                _movieContext.SaveChanges();
                return RedirectToAction("Index", "VideoLibrary");


        }

        [HttpGet]
        //Delete
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Movies.Single(movie => movie.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("Index", "VideoLibrary");
        }

    }



}
