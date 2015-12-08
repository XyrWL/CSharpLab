using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJonesPercent = 4.6;
            double nasdaqPercent = 4.1;
            double stockholmPercent = -2.4;
            double milanoPercent = -6.6;
            double parisPercent = -5.5;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent. Stockholm {2} procent, Milano {3} procent, Paris {4} procent.",
                dowJonesPercent, nasdaqPercent, stockholmPercent, milanoPercent, parisPercent);

            dowJonesPercent = 5.6;
            nasdaqPercent = 4.6;
            stockholmPercent = -3.4;
            milanoPercent = -6.8;
            parisPercent = -4.5;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent. Stockholm {2} procent, Milano {3} procent, Paris {4} procent.",
                dowJonesPercent, nasdaqPercent, stockholmPercent, milanoPercent, parisPercent);

            const double PI = Math.PI;
            Console.WriteLine("Talet pi är cirka {0:F9} men kan avrundas till {0:F2} och kan lite grovt skrivas som {0:F0}.", PI);

            //PI = 3; //Går inte att ändra
            Console.WriteLine("Talet pi är cirka {0:F9} men kan avrundas till {0:F2} och kan lite grovt skrivas som {0:F0}.", PI);

            String name = "Jonas";
            String city = "Helsingborg";
            String area = "Stattena";
            String vicinity = "Hemköp";
            Console.WriteLine($"Han heter {name} och bor i {city} på {area} vid {vicinity}.");

            name = "Peter";
            city = "Madrid";
            area = "Salamanca";
            vicinity = "Corte Ingles";
            Console.WriteLine($"Han heter {name} och bor i {city} på {area} vid {vicinity}.");

            Console.WriteLine(@"Hej
kanin
what");
        }
    }
}