using System;
using System.Globalization;

namespace Rectangle_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();

            Console.WriteLine("-=-=-=-=-=-=-= Rectangle Area =-=-=-=-=-=-=-");

            Console.WriteLine("Enter a height and width of rectangle!");
            Console.Write("A: ");
            rec.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("B: ");
            rec.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine(rec.ToString());
        }
    }
}