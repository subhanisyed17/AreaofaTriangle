// Exercise 1
// Calculate the area of a triangle using Heron's formula
// Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
// Eg. a=3, b=4, c=5. Area = 6


using System;

namespace AreaofaTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the sides of a triangle seperated by commas");
			string input = Console.ReadLine();          // Reading the sides of a traingle as string input
			string[] sideoftriangle = input.Split(','); /*seperates the values present in string into array items when
			                                             an comma is encountered*/
			double a = double.Parse(sideoftriangle[0]);
			double b = double.Parse(sideoftriangle[1]);
			double c = double.Parse(sideoftriangle[2]);
			double s = (a + b + c) / 2;
			double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
			Console.WriteLine("area of triangle is {0}", area);
			Console.ReadKey(true);
		}
	}
}
