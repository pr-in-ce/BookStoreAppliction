﻿using ConsoleToMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }
        public ViewResult Index()
        {
            Title = "Home page from controller";
            CustomProperty = "Custom value";
            Book = new BookModel() { Id = 1, Title = "Asp.Net core Tutorial" };
            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About page from controller";
            return View();
        }

        public ViewResult ContactUs ()
        {
            Title = "ContactUs page from controller";
            return View();
        }
    }
}
