using System;

namespace Printable_DanZam
{
    class Program
    {
        static void Main(string[] args)
        {
            Printable[] printable = new Printable[] { new Book("Пятнадцатилетний капитан", "Жуль Верн", "1878г"),
            new Magasine("Vodolei", "Москва", "Часто посещаемый") };
            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].print();

            }
        }
    }
}
