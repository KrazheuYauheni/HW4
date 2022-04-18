using System;

namespace HW4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Задание 4.1
			Console.WriteLine("Введите кол-во строк: ");
			int lines = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите кол-во столбцов: ");
			int columns = Convert.ToInt32(Console.ReadLine());
			int sum_of_elements = 0;
			Random r_elements = new Random();
			int[,] matrix = new int[lines, columns];
			for (int lines_index = 0; lines_index < lines; lines_index++)
			{
				for (int columns_index = 0; columns_index < columns; columns_index++)
				{
					matrix[lines_index, columns_index] = r_elements.Next(100);
					sum_of_elements += matrix[lines_index, columns_index];
					Console.Write(matrix[lines_index, columns_index]);
				}
			}
			Console.WriteLine("Сумма всех элементов = " + sum_of_elements);


			//Задание 4.2

			Console.WriteLine("Введите длину последовательност:");
			int lenght_of_progression = Convert.ToInt32(Console.ReadLine());
			int[] progression = new int[lenght_of_progression];

			for (int index = 0; index < lenght_of_progression; index++)
			{
				Console.WriteLine("Введите число в последовательность:");
				progression[index] = Convert.ToInt32(Console.ReadLine());
			}
			for (int index = 0; index < lenght_of_progression; index++)
			{
				Console.Write(progression[index]);
			}
			Array.Sort(progression);
			int min_value = 0;
			min_value += progression[0];
			Console.WriteLine("\nНаименьшее число в последовательности = " + min_value);


			// Задание 4.3

			Console.WriteLine("Введите число 2147483647");
			int max_value = Convert.ToInt32(Console.ReadLine());
			Random rnd = new Random();
			int r_number = rnd.Next(max_value);
			while (true)
			{
				Console.WriteLine("Введите загаданное число: ");
				int user_number = Convert.ToInt32(Console.ReadLine());
				if (user_number > r_number)
				{
					Console.WriteLine("Введённое число больше загаданного.");
				}
				else if (user_number < r_number)
				{
					Console.WriteLine("Введённое число меньше загаданного.");
				}
				else
				{
					Console.WriteLine("Вы угадали!");
					break;
				}
			}
		}
	}
}

