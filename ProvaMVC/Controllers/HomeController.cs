using Microsoft.AspNetCore.Mvc;
using ProvaMVC.Models;
using System.Diagnostics;

namespace ProvaMVC.Controllers
{

    //gestisce le richieste /home/*
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //richiesta GET / oppure /home/index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //richieste GET /home/privacy
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();      //restituisce la view /Home/Privacy.cshtml
        }

    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}