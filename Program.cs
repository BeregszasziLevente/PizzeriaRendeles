using PizzeriaRendeles;
using System.IO;

List<Rendeles> rendelesek = new List<Rendeles>();

foreach(string sor in File.ReadAllLines("rendelesek.txt")) { 
    rendelesek.Add(new Rendeles(sor));
}