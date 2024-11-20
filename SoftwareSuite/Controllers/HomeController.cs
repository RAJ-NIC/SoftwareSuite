using Microsoft.AspNetCore.Mvc;
using SoftwareSuite.Models;
using System.Diagnostics;

namespace SoftwareSuite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var imageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "slides");
            var imageFiles = Directory.GetFiles(imageDirectory)
                                      .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                      .Select(file => "/images/slides/" + Path.GetFileName(file))
                                      .ToList();

            // Pass image paths to the view
            ViewBag.ImageFiles = imageFiles;

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
