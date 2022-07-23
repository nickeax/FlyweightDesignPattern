using FlyweightUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightUI.Factories
{
    public class CarOrderFlyweightFactory
    {
        private Dictionary<string, Configuration> _coff;

        public CarOrderFlyweightFactory()
        {
            _coff = new Dictionary<string, Configuration>();
        }

        public Order Create(EngineGearbox eg, string make)
        {
            if (_coff.ContainsKey(eg.ToString()))
            {
                Console.WriteLine($"Using existing configuration. (HashCode: {_coff[eg.ToString()].GetHashCode()})");
                Car c = new Car(Guid.NewGuid(), make, _coff[eg.ToString()]);
                Order tmpOrder = new Order
                {
                    Id = Guid.NewGuid(),
                    Car = c
                };

                return tmpOrder;
            }
            else
            {
                Configuration con = new Configuration(eg);
                Console.WriteLine($"Creating a new configuration. (HashCode: {con.GetHashCode()})");
                _coff.Add(eg.ToString(), con);
                Car c = new Car(Guid.NewGuid(), make, con);
                Order tmpOrder = new Order
                {
                    Id = Guid.NewGuid(),
                    Car = c
                };

                return tmpOrder;
            }
        }
    }
}
