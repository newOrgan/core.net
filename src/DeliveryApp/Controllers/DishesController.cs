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
        public IActionResult Index(string id) 
        {

            ViewBag.Dish = Convert.ToInt32(id.Substring(0,1));
            ViewBag.Rest = Convert.ToInt32(id.Substring(2,id.ToString().Length-2));
            return View(db.Dishes.ToList());
            
        }
        

    }
}