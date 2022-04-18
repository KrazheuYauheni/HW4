using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 3.1
            Console.WriteLine("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Вы ввели чётное число.");
            }
            else
            {
                Console.WriteLine("Вы ввели нечётное число");
            }
            Console.ReadKey();

            //Задание 3.2
            Console.WriteLine("Добро пожаловать в наше казино!");
            Console.WriteLine("Введите количество ваших карт:");
            int num_of_cards = Convert.ToInt32(Console.ReadLine());
            int sum_of_cards = 0;
            for (int i = 1; i <= num_of_cards; i++)
            {
                Console.WriteLine($"Введите наминал {i}-й карты:");
                string quantity = Console.ReadLine();
                switch (quantity)
                {
                    case "2":
                        sum_of_cards += 2; break;
                    case "3":
                        sum_of_cards += 3; break;
                    case "4":
                        sum_of_cards += 4; break;
                    case "5":
                        sum_of_cards += 5; break;
                    case "6":
                        sum_of_cards += 6; break;
                    case "7":
                        sum_of_cards += 7; break;
                    case "8":
                        sum_of_cards += 8; break;
                    case "9":
                        sum_of_cards += 9; break;
                    case "10":
                        sum_of_cards += 10; break;
                    case "J":
                        sum_of_cards += 10; break;
                    case "Q":
                        sum_of_cards += 10; break;
                    case "K":
                        sum_of_cards += 10; break;
                    case "T":
                        sum_of_cards += 10; break;
                }
            }
            Console.WriteLine($"Сумма ваших карт = {sum_of_cards}");
            Console.ReadKey();

            //Задание 3.3
            Console.WriteLine("Введите целое число: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            double denominator = 1;
            bool n = false;
            while (denominator < numerator)
            {
                denominator++;
                double result = numerator % denominator;
                if (result != 0)
                {
                    continue;
                }
                else
                {
                    n = true;
                    break;
                }

            }
            if (n == false)
            {
                Console.WriteLine("Чесло простое");
            }
            else
            {
                Console.WriteLine("Число составное");
            }
        }
    }
}
