using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2.1
            string fullname = "Никита Геннадьевич Сиднев";
            int age = 35;
            string email = "Nike@gmail.com ";
            double progScore = 88;
            double mathScore = 76;
            double physScore = 81;
            string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(pattern,
                fullname,
                age,
                email,
                progScore,
                mathScore,
                physScore);
            Console.ReadKey();

            //Задание 2.2
            double sumScore = progScore + mathScore + physScore;
            double averScore = sumScore / 3;
            Console.WriteLine($"Средний балл:{averScore}");
            Console.ReadKey();
        }
    }
}
