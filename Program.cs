using PizzeriaRendeles;
using System.IO;

List<Rendeles> rendelesek = new List<Rendeles>();

Console.WriteLine("Napi rendelések:");
foreach(string sor in File.ReadAllLines("rendelesek.txt")) { 
    Rendeles peldany = new Rendeles(sor);
    rendelesek.Add(peldany);
    Console.WriteLine(peldany);
}

Console.WriteLine("\nStatisztika:");
Console.WriteLine($"Pizzéria teljes napi bevétele: {rendelesek.Sum(x=>x.FizetendoDij())} Ft");
Console.WriteLine($"Legtöbb pizzát rendelő vásárló: {rendelesek.MaxBy(x=>x.PizzakSzama).VevoNev} ({rendelesek.Max(x => x.PizzakSzama)} db)");