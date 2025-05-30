using System;
using System.Collections.Generic;
using System.Linq;

var cars = new List<string>();
cars.Add("Civic");
cars.Add("Corolla"); 
cars.Add("Gol");
cars.Add("Onix");
cars.Add("Fiesta");
cars.Add("HB20");
cars.Add("Argo");
cars.Add("Cruze");
cars.Add("Ka");
cars.Add("Uno");

Console.WriteLine(cars.First());
Console.WriteLine(cars.FirstOrDefault("Not Found"));
Console.WriteLine(cars.Any(c => c == "Fiesta"));
Console.WriteLine(cars.All(c => c == "Fiesta"));
Console.WriteLine(cars.Count());
Console.WriteLine(cars.Count(c => c == "Uno"));
Console.WriteLine(cars.ElementAt(5));
Console.WriteLine(cars.Single(c => c == "Corolla"));
Console.WriteLine(cars.Last());
// ---------------------------------
foreach (var car in cars.Take(2..5))
    Console.WriteLine(car);
 //-----------------------  
foreach (var car2 in cars.Where(c => c == "Corolla" || c == "Uno"))
   Console.WriteLine(car2);
//----------------------
foreach (var car3 in cars.Skip(4))
   Console.WriteLine(car3);