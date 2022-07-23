using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightUI.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public Configuration Configuration { get; set; }

        public Car(Guid g, string make, Configuration c)
        {
            Id = g;
            Make = make;
            Configuration = c;
        }
    }
}
