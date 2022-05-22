using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string input = " ";

            while (input != "exit")
            {
                Console.WriteLine("Введите число, sum или exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "sum" :
                        ShowSum(numbers);
                        break;
                    case "exit":
                        Console.WriteLine("Выход");
                        break;
                    default:
                        AddNumber(numbers, input);
                        break;
                }
            }
        }

        static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма: {sum}");
        }

        static void AddNumber(List<int> numbers,string input)
        {
            int number;

            if (int.TryParse(input, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
    }
}