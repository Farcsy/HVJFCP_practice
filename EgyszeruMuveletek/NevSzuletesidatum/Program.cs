using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevSzuletesidatum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tájékoztatás, adatbekérés
            Console.WriteLine("Helló, kérlek add meg a neved:");
            string name = Console.ReadLine();
            Console.WriteLine("Kérlek add meg a születési dátumodat, a következő formában:");
            Console.WriteLine("[ÉÉÉÉ.HH.NN]");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Köszönöm!");

            double age = DateTime.Now.Subtract(birth).Days / 365.25;
            Console.WriteLine(String.Format("Szia {0}, te {1} éves vagy.", name, (int)age));
            Console.ReadLine();
        }
    }
}
