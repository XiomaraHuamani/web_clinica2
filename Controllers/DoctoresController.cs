using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_clinica.Models;

namespace web_clinica.Controllers
{
    public class DoctoresController : Controller
    {
        private readonly ILogger<DoctoresController> _logger;

        public DoctoresController(ILogger<DoctoresController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
