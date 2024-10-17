using System;
using System.Linq;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Temel Dizi Örnekleri

			//string[] colors = new string[4];
			//colors[0] = "Kırmızı";
			//colors[1] = "Sarı";
			//colors[2] = "Beyaz";
			//colors[3] = "Mavi";

			//Console.WriteLine(colors[2]);

			//string[] cities = new string[5];
			//cities[0] = "Milano";
			//cities[1] = "Budapeşte";
			//cities[2] = "Lyon";
			//cities[3] = "Kahire";
			//cities[4] = "Üsküp";

			//Console.WriteLine(cities[4]);

			//int[] numbers = new int[10];
			//numbers[0] = 50;
			//numbers[1] = 48;
			//numbers[2] = 698;
			//numbers[3] = 24;
			//numbers[7] = 748;

			//Console.WriteLine(numbers[3]);

			//string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

			//Console.WriteLine(cities[3]);

			#endregion

			#region Dizideki Tüm Elemanları Listeleme

			//string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}

			//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 3 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//char[] symbols = { 'a', 'b', 'c', '*', '/', '-', '+' };

			//for (int i = 0; i < symbols.Length; i++)
			//{
			//	Console.WriteLine(symbols[i]);
			//}

			//int[] myArrays = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

			//int maxNumber = myArrays[0];

			//for (int i = 1; i < myArrays.Length; i++)
			//{
			//	if (myArrays[i] > maxNumber)
			//	{
			//		maxNumber = myArrays[i];
			//	}
			//}
			//Console.WriteLine(maxNumber);

			//string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
			//Console.WriteLine(persons.Length);

			//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
			//Array.Sort(numbers);
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);	
			//}

			//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
			//Array.Reverse(numbers);
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			#endregion

			#region Dizi Metotları

			//string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
			//int index = Array.IndexOf(customers, "Merve");
			//Console.WriteLine(index);

			//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
			//Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
			//Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());

			#endregion

			#region Kullanıcıdan Değer Alma

			//string[] cities = new string[5];

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.Write($"Lütfen {i+1}. Şehri giriniz: ");
			//	cities[i] = Console.ReadLine();
			//}

			//Console.WriteLine("-----------------------");

			//for (int i = 0;i < cities.Length;i++)
			//{
			//	Console.WriteLine(cities[i]);
			//}

			#endregion

			Console.Read();
		}
	}
}
