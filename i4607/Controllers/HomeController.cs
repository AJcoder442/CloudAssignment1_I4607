using System.Diagnostics;
using i4607.Models;
using Microsoft.AspNetCore.Mvc;


namespace i4607.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Architecture()
        {
            return View();
        }

        public IActionResult AzureServices()
        {
            return View();
        }
    }
}
