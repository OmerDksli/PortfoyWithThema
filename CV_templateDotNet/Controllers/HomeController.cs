﻿using CV_templateDotNet.Data;
using CV_templateDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CV_templateDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        private readonly CVtemplateDotNetContext _context;
        public HomeController(ILogger<HomeController> logger,CVtemplateDotNetContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult ThemUI() 
        {
            return View();
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
