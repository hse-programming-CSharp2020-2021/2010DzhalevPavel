// Author: Pavel Dzhalev
// Created on 27 05 2021

using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Index();
        }
    }
}