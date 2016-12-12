using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Models
{
    public class DeliveryContext: DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options)
        { }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
       
    }
}
