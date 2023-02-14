using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jslaugh8.Controllers
{
    public class PodCastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
