using System;

namespace lab2_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть масивiв \t");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Random rnd = new Random();
                int rndnumber;
                for (i = 0; i < myArray.Length; i++)
                {
                    rndnumber = rnd.Next(-100, 100);
                    myArray[i] = rndnumber;
                    Console.Write($"\nЕлемент массива пiд iндексом {i}:\t " + myArray[i]);
                }
            }

            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
                if (myArray[i] < 7)
                    sum += 1;
            Console.WriteLine("\nКiлькiсть чисел меньше сiм:" + sum);
            int minid = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0)
                {
                    minid = i;
                    break;
                }
            }

            int maxid = 0;
            for (int i = myArray.Length - 1; i > 0; i--)
            {
                if (myArray[i] > 0)
                {
                    maxid = i;
                    break;
                }
            }

            int a = 0;
            for (int i = minid; i <= maxid; i++)
            {
                a += myArray[i];
            }
            Console.WriteLine("Кiлькiсть чисел розташованих мiж першим й останнiм додатними:" + a);
        }
    }
}