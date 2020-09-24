using System;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Site.Controllers
{
    public class HomeController : Controller
    {
    public IActionResult Index()
        {
            return View();
        }
    }
}
