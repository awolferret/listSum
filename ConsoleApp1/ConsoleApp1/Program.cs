using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            var input = " ";
            int sum = 0;

            while (input != "exit")
            {
                Console.WriteLine("Введите число, sum или exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "sum" :

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine($"Сумма: {sum}");
                        sum = 0;
                        break;
                    case "exit":
                        Console.WriteLine("Выход");
                        break;
                    default:
                        int number = Convert.ToInt32(input);
                        numbers.Add(number);
                        break;
                }
            }
        }
    }
}