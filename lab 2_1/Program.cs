using System;

namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число");
            int num = int.Parse(Console.ReadLine());
            switch (num) { 
                case 10 : Console.WriteLine("десять"); break;
                case 11 : Console.WriteLine("одинадцять"); break;
                case 12 : Console.WriteLine("дванадцять"); break;
                case 13 : Console.WriteLine("тринадцять"); break;
                case 14 : Console.WriteLine("чотирнадцять"); break;
                case 15 : Console.WriteLine("п'ятнадцять"); break;
                case 16 : Console.WriteLine("шiстнадцять"); break;
                case 17 : Console.WriteLine("сiмнадцять"); break;
                case 18 : Console.WriteLine("вiсiмнадцять"); break;
                case 19 : Console.WriteLine("дев'ятнадцять"); break;
                case 20 : Console.WriteLine("двадцять"); break;
                default: Console.WriteLine("введiть ще раз"); break;
            }
        }
    }
}
