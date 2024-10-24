using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar

			//void CustomerList()
			//{
			//	Console.WriteLine("Ali Yıldız");
			//	Console.WriteLine("Ayşe Yıldız");
			//	Console.WriteLine("Hakan Öztürk");
			//	Console.WriteLine("Merve Çınar");
			//}

			//CustomerList();

			//void Sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}
			//Sum();

			#endregion

			#region Void Metotlar (String Parametreli)

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}

			//WriteMethod("Onur YILMAZ");

			//void CustomerCard(string name, string surname)
			//{
			//	Console.WriteLine("Müşteri : " + name + " " + surname);
			//}

			//CustomerCard("Onur", "Yılmaz");
			//CustomerCard("Ayşegül", "Kaya");

			#endregion

			#region Void Metotlar (Int Parametreli)

			//void Sum(int number1, int number2 , int number3)
			//{
			//	int result = number1 + number2 + number3;
			//	Console.WriteLine(result);
			//}

			//Sum(1, 2, 3);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			//string CustomerName()
			//{
			//	return "Buse YILDIZ";
			//}

			//CustomerName();

			//string StudentCard()
			//{
			//	string name = "Ali";
			//	string surname = "Kaya";

			//	return name + " " + surname;
			//}

			//Console.WriteLine(StudentCard());

			#endregion

			#region Geriye Değer Döndüren String Parametreli Metotlar

			//string CountryCard(string countryName , string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak rengi: " + flagColor + "\n------------------------";
			//	return cardInfo;
			//}

			//string x, y, z;
			//Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();
			//Console.Write("Başkenti Giriniz: ");
			//y = Console.ReadLine();
			//Console.Write("Bayrak Rengini Giriniz: ");
			//z = Console.ReadLine();
			//Console.WriteLine("------------------------");

			//Console.WriteLine(CountryCard(x,y,z));

			#endregion

			#region Geriye Değer Döndüren Int Parametreli Metotlar

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;
			//	return result;
			//}

			//Console.WriteLine(Sum(45,56));
			//Console.WriteLine(Sum(55,86));
			//Console.WriteLine(Sum(65,6));
			//Console.WriteLine(Sum(75,76));

			#endregion

			Console.Read();
		}
	}
}
