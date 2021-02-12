using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int n;
            Random random = new Random();
            Console.WriteLine("Введіть к-ть елементів: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Не допустиме значення");
                return;
            }

            Console.WriteLine("Ви ввели: {0}", n);
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(2,101);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mas[i]}\t"); 
            }
            Console.WriteLine();
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine($"Максимальний елемент {max} ");

        }
    }
}
