using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			//string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

			//foreach (string x in cities)
			//{
			//	Console.WriteLine(x);
			//}

			//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			//foreach (int number in numbers)
			//{
			//	if (number % 2 == 0)
			//	{
			//		Console.WriteLine(number);
			//	}
			//}

			//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
			//int total = 0;

			//foreach (int number in numbers)
			//{
			//	total += number;
			//}
			//Console.WriteLine(total);

			//List<int> numbers = new List<int>()
			//{
			//	1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
			//};

			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//string word = "Merhaba";

			//foreach (char c in word)
			//{
			//	Console.WriteLine(c);
			//}

			#endregion

			#region Örnek Sınav Sistemi

			//Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
			//Console.WriteLine();

			//Console.WriteLine("--------------------------------------------");
			//Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
			//int studentCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("--------------------------------------------");

			//string[] studentName = new string[studentCount];
			//double[] studentExamAvg = new double[studentCount];

			//for (int i = 0; i < studentCount; i++)
			//{
			//	Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
			//	studentName[i] = Console.ReadLine();

			//	double totalExamResult = 0;

			//	for (int j = 0; j < 3; j++)
			//	{
			//		Console.Write($"{studentName[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
			//		double value = double.Parse(Console.ReadLine());
			//		totalExamResult += value;
			//	}
			//	Console.WriteLine("--------------------------------------------");

			//	studentExamAvg[i] = totalExamResult / 3;
			//}

			//for (int i = 0;i < studentCount;i++)
			//{
			//	Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
				

			//	if(studentExamAvg[i] >= 50)
			//	{
			//		Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
			//		Console.WriteLine("--------------------------------------------");

			//	}
   //             else
   //             {
			//		Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
			//		Console.WriteLine("--------------------------------------------");
			//	}
			//}
			//Console.WriteLine();
			//Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");

			#endregion

			Console.Read();
		}
	}
}
