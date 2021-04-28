using System;

namespace lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, x = 1.25, b = 6.75, dx = 0.25;
            Console.WriteLine("\t  X\t\t\tY\n");
            while (x <= b)
            {
                y = Math.Pow(x, 1/3) - 12 * x + Math.Exp(3*x);
                Console.WriteLine("\t|" + x + "\t\t\t" + Math.Round(y, 2) + "\t|");
                x += dx;
            }
        }
    }
}
