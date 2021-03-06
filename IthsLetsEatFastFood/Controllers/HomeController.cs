﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Drinko.Models;
using Drinko.Repository;
using Microsoft.AspNetCore.Http;

namespace Drinko.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _ProductRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository ProductRepository)
        {
            _logger = logger;
            _ProductRepository = ProductRepository;
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




       // public IActionResult create()
      // {
        //    string key = "MyCookie";
         //  string value = "DRINKO COOKIE";
          // CookieOptions cookieOptions = new CookieOptions();
          // cookieOptions.Expires = DateTime.Now.AddDays(7);
           //Response.Cookies.Append(key, value, cookieOptions);
           //return View("Index");
      // }
    }

}
