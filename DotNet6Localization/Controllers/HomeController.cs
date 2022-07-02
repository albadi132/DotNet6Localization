﻿using DotNet6Localization.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Localization;
using DotNet6Localization.Resources;

namespace DotNet6Localization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /* Localization Inject */
        private readonly IStringLocalizer<SharedResource> _loc;
        public HomeController(ILogger<HomeController> logger , IStringLocalizer<SharedResource> loc)
        {
            _logger = logger;
            _loc = loc;
        }

        public IActionResult Index()
        {
            //Using from Controllers
            var salim = _loc.GetString("salim").Value;

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