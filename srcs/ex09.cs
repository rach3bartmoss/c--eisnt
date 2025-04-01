/*faça um programa que receba numeros reais, quando for entrada do numero zero o progrma devera apresentar quantos valores
foram recebidos e a media dos mesmo*/

using	System;

namespace eisnt
{
	class Program
	{
		static int	Factorial(int n)
		{
			int	count = n;
			int	result = 1;
			if (n == 0 || n == 1)
			{
				return (1);
			}
			while (count > 0)
			{
				result *= count;
				count--;
			}
			return (result);
		}
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("Program must receive at least one parameter");
				return ;
			}
			int		i = 0;
			double	med = 0;

			while (i < args.Length && Convert.ToDouble(args[i]) != 0)
			{
				double n = double.Parse(args[i]);
				med += n;
				i++;
			}
			med /= (double)i;
			Console.WriteLine($"Média {med:F1}\nNumero de valores recebidos: {i}");

			//int	value = int.Parse(Console.ReadLine());

			//int	factor = Factorial(value);
			//Console.WriteLine($"{factor}");
			string	answer;
			do
			{
				int value = int.Parse(Console.ReadLine()); 
				int factor = Factorial(value);
				Console.WriteLine($"Factorial of {value} is: {factor}");
				Console.WriteLine($"Want to run another number? (y/n)");
				answer = Console.ReadLine();
				if (answer == "y")
				{
					Console.WriteLine("Please insert number:");
				}
				else
				{
					break ;
				}
			} while (answer != "n");
		}
	}
}