using System;
using System.Data;

namespace	ex16
{
	class Ex16
	{
		static void	Main(string[] args)
		{
			Console.WriteLine("Insira os lados do triangulo: a, b, c");
			int a = int.Parse(args[0]);
			int b = int.Parse(args[1]);
			int c = int.Parse(args[2]);

			if ((a <= 0 || b <= 0 || c <= 0) || (!IsTriangle(a, b, c)))
			{
				Console.WriteLine("Não é um triagulo");
				return ;
			}
			if (a == b && b == c && a == c)
			{
				Console.WriteLine("É um triângulo equilátero");
				return ;
			}
			else if (a != b && b != c && a != c)
			{
				Console.WriteLine("É um triângulo escaleno");
				return ;
			}
			else if (Isosceles(a, b, c))
			{
				Console.WriteLine("É um triângulo isósceles");
				return ;
			}
		}
		static bool Isosceles(int a, int b, int c)
		{
			return (a == b || b == c || a == c);
		}

		static bool IsTriangle(int a, int b, int c)
		{
			if ((a + b < c) || (a + c < b) || (b + c < a))
				return (false);
			return (true);
		}
	}
	public static DateTime proxDia()
	{
		DateTime d = DateTime.Now.AddDays(1);
		return d;
	}
}