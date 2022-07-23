using FlyweightUI.Factories;
using FlyweightUI.Models;

Orders carOrders = new Orders();
Console.WriteLine("Order Creation Details");
CarOrderFlyweightFactory coff = new CarOrderFlyweightFactory();

carOrders.Add(coff.Create(EngineGearbox.V4_5_A, "Toyota"));
carOrders.Add(coff.Create(EngineGearbox.V4_5_A, "Toyota"));
carOrders.Add(coff.Create(EngineGearbox.V4_5_A, "Toyota"));
carOrders.Add(coff.Create(EngineGearbox.V4_5_M, "Toyota"));
carOrders.Add(coff.Create(EngineGearbox.V6_6_M, "Ford"));
carOrders.Add(coff.Create(EngineGearbox.V8_7_A, "Holden"));
carOrders.Add(coff.Create(EngineGearbox.V4_5_A, "Toyota"));

carOrders.Show();
