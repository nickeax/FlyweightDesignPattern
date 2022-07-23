using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightUI.Models
{
    public class Configuration
    {
        public int Cylinders { get; set; }
        public int Gears { get; set; }
        public string Transmission { get; set; }

        public Configuration(EngineGearbox e)
        {
            switch (e.ToString())
            {
                case "V4_5_A":
                    Cylinders = 4;
                    Gears = 5;
                    Transmission = "auto";
                    break;
                case "V4_5_M":
                    Cylinders = 4;
                    Gears = 5;
                    Transmission = "manual";
                    break;
                case "V6_6_A":
                    Cylinders = 6;
                    Gears = 6;
                    Transmission = "auto";
                    break;
                case "V6_6_M":
                    Cylinders = 6;
                    Gears = 6;
                    Transmission = "manual";
                    break;
                case "V8_7_A":
                    Cylinders = 8;
                    Gears = 7;
                    Transmission = "auto";
                    break;
                case "V8_7_M":
                    Cylinders = 8;
                    Gears = 7;
                    Transmission = "manual";
                    break;
                default:
                    throw new Exception("No such configuration, not created");
            }
        }
    }
}
