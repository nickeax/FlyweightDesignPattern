using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightUI.Models
{
    public class Orders
    {
        private List<Order> _orders;

        public Orders()
        {
            _orders = new List<Order>();
        }

        public void Add(Order o)
        {
            if (o != null) _orders.Add(o);
        }

        public void Show()
        {
            Console.WriteLine("\n\nOrder Details");
            foreach (var order in _orders)
            {
                Console.WriteLine($"OrderId: {order.Id}, " +
                    $"Car ({order.Car.Make}, " +
                    $"V{order.Car.Configuration.Cylinders}, " +
                    $"{order.Car.Configuration.Gears} speed {order.Car.Configuration.Transmission})");
            }
        }
    }
}
