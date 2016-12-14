using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Models;
namespace DeliveryApp.Models
{
    public class Dishes
    {
        public int id { get; set; }
        public string string_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int type { get; set; }
        public int key { get; set; }
        public int Restaurant { get; set; }
    }
}
