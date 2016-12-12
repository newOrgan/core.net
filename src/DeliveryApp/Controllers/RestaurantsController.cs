using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliveryApp.Models;

namespace DeliveryApp.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly DeliveryContext _context;

        public RestaurantsController(DeliveryContext context)
        {
            _context = context;    
        }

        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurants = await _context.Restaurants.SingleOrDefaultAsync(m => m.id == id);
            if (restaurants == null)
            {
                return NotFound();
            }

            return View(restaurants);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,adress,kitchen,name,spec,string_id")] Restaurants restaurants)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurants);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(restaurants);
        }

        // GET: Restaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurants = await _context.Restaurants.SingleOrDefaultAsync(m => m.id == id);
            if (restaurants == null)
            {
                return NotFound();
            }
            return View(restaurants);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,adress,kitchen,name,spec,string_id")] Restaurants restaurants)
        {
            if (id != restaurants.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurants);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantsExists(restaurants.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(restaurants);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurants = await _context.Restaurants.SingleOrDefaultAsync(m => m.id == id);
            if (restaurants == null)
            {
                return NotFound();
            }

            return View(restaurants);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurants = await _context.Restaurants.SingleOrDefaultAsync(m => m.id == id);
            _context.Restaurants.Remove(restaurants);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RestaurantsExists(int id)
        {
            return _context.Restaurants.Any(e => e.id == id);
        }
    }
}
