using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeliveryApp.Models;

namespace DeliveryApp.Controllers
{
    public class DishesController : Controller
    {
        DeliveryContext db;
        public DishesController(DeliveryContext context)
        {
            db = context;
        }
        public IActionResult Index(int id ,int rest) 
        {
            ViewBag.Dish = id;
            ViewBag.Rest = rest;
            return View();
            
        }
       
    }
}