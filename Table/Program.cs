using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a, b, result = 0;
            int goodresult = 0, badresult = 0;
            int count = random.Next(7, 13);
            int[] questions = new int[count];

            for (int i = 0; i < count; i++)
            {
                int goodAnswer = 0;
                while (true)
                {
                    a = random.Next(2, 10);
                    b = random.Next(2, 10);
                    goodAnswer = a * b;
                    bool isPovtor = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (questions[j] == goodAnswer)
                        {
                            isPovtor = true;
                        }
                    }
                    if (!isPovtor)
                        break;
                    else
                    {
                        Console.WriteLine("----Був повтор----- {0} {1}", a, b);
                    }
                }
                Console.Write("{0} x {1} = ", a, b);
                
                result = GetValueConsole();


                if (result == goodAnswer)
                    goodresult++;
                else
                    badresult++;
                questions[i] = goodAnswer;
            }
            Console.WriteLine($"К-ть правильних відповідей: {goodresult} ");
            Console.WriteLine($"К-ть неправильних відповідей: {badresult} ");
            int mark = (100 * goodresult) / count;
            Console.WriteLine($"Ваша оцінка: {mark} ");
        }

        private static int GetValueConsole()
        {
            int value = 0;
            while (true)
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка вводу даних! {0}", ex.Message);
                    continue;
                }
            }
            return value;
        }
    }
}
