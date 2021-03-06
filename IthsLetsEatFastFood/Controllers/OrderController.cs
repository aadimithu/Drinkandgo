﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinko.Models;
using Drinko.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Drinko.Controllers
{
    public class OrderController : Controller
    {

        private readonly IProductRepository _ProductRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        private const string sessionKeyCart = "_cart";
        private const string sessionKeyUserId = "_userId";


        public OrderController(IProductRepository ProductRepository, UserManager<ApplicationUser> userManager)
        {
            _ProductRepository = ProductRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}