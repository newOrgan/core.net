using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Models;

namespace DeliveryApp.Models
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; } // имя фамилия покупателя
        public string adress { get; set; } // адрес покупателя
        public string phone { get; set; } // контактный телефон покупателя
        public int DishesID { get; set; }
        public Dishes Dishes { get; set; }
    }
}
