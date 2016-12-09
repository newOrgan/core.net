using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Dishes
    {
        public int dish_id { get; set; }
        public string dish_string_id { get; set; }
        public string dish_name { get; set; }
        public double dish_price { get; set; }
        public int dish_type { get; set; }
        public int dish_key { get; set; }
        public Restaurants Restaurant { get; set; }
    }
}
