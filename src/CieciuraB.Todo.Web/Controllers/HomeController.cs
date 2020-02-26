using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CieciuraB.Todo.Web.Models;
using CieciuraB.Todo.Web.Persist.Domain;
using Microsoft.AspNetCore.Http;

namespace CieciuraB.Todo.Web.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult List()
        {
            if (HttpContext.Session.GetString("session_user") != null)
            {
                List<Item> items = Persist.ContekstDb.Items;
                return View(items);
            }
            else
            {
                return Redirect("~/Account/LogIn");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

    }
}