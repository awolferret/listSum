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
                        Sum(numbers);
                        break;
                    case "exit":
                        Console.WriteLine("Выход");
                        break;
                    default:
                        AddNumbers(ref numbers, input);
                        break;
                }
            }
        }

        static void Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма: {sum}");
            sum = 0;
        }

        static void AddNumbers(ref List<int> numbers,string input)
        {
            int number;
            int.TryParse(input, out number);
            numbers.Add(number);
        }
    }
}