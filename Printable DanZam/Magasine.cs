using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable_DanZam
{
    public class Magasine : Printable
    {
        string Name;
        string Geolocation;
        string Popularity;
        public Magasine(string Name, string Geolocation, string Popularity)
        {
            this.Name = Name;
            this.Geolocation = Geolocation;
            this.Popularity = Popularity;
        }
        public void print()
        {
            Console.WriteLine($"Название магазина: {Name}, Расположение: {Geolocation}, Попклярность: {Popularity}");
        }

        public static void printMagazines(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Book)
                {
                    printable[i].print();
                }
            }
        }
    }
}
