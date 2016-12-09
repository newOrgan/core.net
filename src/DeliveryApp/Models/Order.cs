using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Models;

namespace DeliveryApp.Models
{
    public class Order
    {
        public int order_id { get; set; }
        public string order_name { get; set; } // имя фамилия покупателя
        public string order_adress { get; set; } // адрес покупателя
        public string order_phone { get; set; } // контактный телефон покупателя
        public int order_key { get; set; }
        public Dishes Dishes { get; set; }
    }
}
