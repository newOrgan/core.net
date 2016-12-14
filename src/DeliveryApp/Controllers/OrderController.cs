using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeliveryApp.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryApp.Controllers
{
    public class OrderController : Controller
    {
       
        DeliveryContext db;
        public OrderController(DeliveryContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Orders.ToListAsync());
        }
        public IActionResult Create(int id)
        {
            ViewBag.dishesid = id;
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
