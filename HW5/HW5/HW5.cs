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
			PrintWords2(ReversWords2(sentence));
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
		/// <summary>
		/// Меняет порядок элеиентов в массиве на обратный
		/// </summary>
		/// <param name="inputPhrase"></param>
		/// <returns></returns>
		static string[] ReversWords(string inputPhrase)
        {
			string[] words = ConvertStrToMas(inputPhrase);
			//Array.Reverse(words);
	        //return words;
			string[] revPharase = new string[words.Length];
			for (int i = 0; i < words.Length; i++)
            {
				revPharase[i] = words[words.Length-1-i];
            }
			return revPharase;
        }
		/// <summary>
		/// Меняет порядок элеиентов в массиве на обратный(другой вариант)
		/// </summary>
		/// <param name="inputPhrase"></param>
		/// <returns></returns>
		static string[] ReversWords2(string inputPhrase)
		{
			string[] words = ConvertStrToMas(inputPhrase);
			//Array.Reverse(words);
			//return words;
			string[] revPharase = new string[words.Length];
			int j = 0;
			for (int i = words.Length - 1; i >= 0; i--)
			{
				revPharase[j] = words[i];
				j++;
			}
			return revPharase;
		}
		/// <summary>
		/// Выводит массив в обратном порядке
		/// </summary>
		/// <param name="massive"></param>
		static void PrintWords2(string[] massive)
		{
			foreach (string word in massive)
			{
				Console.Write($"{word} ");
			}
		}
		
	}
}
