using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission6_jslaugh8.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Mission6_jslaugh8.Controllers
{
    public class VideoLibraryController : Controller
    {

        private readonly ILogger<VideoLibraryController> _logger;
        private MovieContext _movieContext { get; set; }

        public VideoLibraryController(ILogger<VideoLibraryController> logger, MovieContext movieContext)
        {
            _logger = logger;
            _movieContext = movieContext;

        }
        public IActionResult Index()
        {
            var movies = _movieContext.Movies.Include(x => x.Category)
                .OrderBy(movie =>movie.Year)
                .ToList();

            return View(movies);
        }
    }
}
