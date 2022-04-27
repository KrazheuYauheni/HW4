using System;

namespace HW5
{
    internal class HW5
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите предложение: ");
			string sentence = Console.ReadLine();
			string [] massive = ConvertStrToMas(sentence);
			PrintWords(massive);
		}
		/// <summary>
		/// Возвражает массив слов, которые разделены пробелом
		/// </summary>
		/// <param name="sentence">Предложение</param>
		/// <returns>Массив</returns>
		static string[] ConvertStrToMas(string sentence)
		{
			return sentence.Split(' ');
		}
		/// <summary>
		/// Выводит в консоль элементы массива 
		/// </summary>
		/// <param name="massive"></param>
		static void PrintWords(string [] massive)
		{
			foreach (string word in massive)
			{
				Console.WriteLine(word);
			}
		}
}
}
