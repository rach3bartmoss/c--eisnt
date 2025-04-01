using System;
class Program
{
	static void Main(string[] args)
	{
		DateTime d1 = proxDia();

		Console.WriteLine(d1);

		double	iva = iva_calculator(99.99);
		int reps = 450 / 100;
		Console.WriteLine($"{iva:F3}, {reps}");

		Console.WriteLine("Insira um valor entre 1 e 500: ");
		//int	value = int.Parse(Console.ReadLine());
	
		string roman = roman_converter(449);
		Console.WriteLine($"Sua representação em algarismos romanos: {roman}");

		Console.WriteLine("\nInsira dois valores para operação e o operando: <n1, sinal, n2>");
		dynamic		n1 = toDynamic(Console.ReadLine());
		char	signal = char.Parse(Console.ReadLine());
		dynamic		n2 = toDynamic(Console.ReadLine());

		calculator(n1, n2, signal);

	}

	private static double	iva_calculator(double fatura)
	{
		double	iva_tax = (fatura / 100) * 24;
		return (iva_tax);
	}

	public static dynamic	toDynamic(string input)
	{
		if (int.TryParse(input, out int intValue))
			return intValue;
		else if (float.TryParse(input, out float floatValue))
			return floatValue;
		else if (double.TryParse(input, out double doubleValue))
			return doubleValue;
		else
			return 0;
	}

	public static void	calculator(dynamic n1, dynamic n2, char signal)
	{
		if (n1 == 0 || n2 == 0)
		{
			Console.WriteLine("None of the operands can be zero.");
			return ;
		}
		if (signal == '+')
		{
			Console.WriteLine($"Result of {n1} + {n2}: {n1 + n2}");
			return ;
		}
		else if (signal == '-')
		{
			Console.WriteLine($"Result of {n1} - {n2}: {n1 - n2}");
			return ;
		}
		else if (signal == '/')
		{
			double result = Convert.ToDouble(n1) / Convert.ToDouble(n2);
			Console.WriteLine($"Result of {n1} / {n2}: {result}");
			return ;
		}
		else if (signal == '*')
		{
			Console.WriteLine($"Result of {n1} * {n2}: {n1 * n2}");
			return ;
		}
	}

	public static string roman_converter(int value)
	{
		string	result = "";

		if (value == 500)
		{
			result += "D";
			return (result);
		}
		if (value >= 400)
		{
			result+= "CD";
			value -= 400;
		}
		while (value != 0)
		{
			int	reps = 0;
			if (value / 100 != 0)
			{
				reps = value / 100;
				value -= (reps * 100);
				while (reps > 0)
				{
					result += "C";
					reps--;
				}
			}
			if (value / 50 != 0)
			{
				reps = value / 50;
				
				if (value < 100 && value >= 90)
				{
					result += "XC";
					value -= 90;
					reps = 0;
				}
				Console.WriteLine(reps);
				value -= (reps * 50);
				while (reps > 0)
				{
					result += "L";
					reps--;
				}
			}
			if (value / 10 != 0)
			{
				reps = value / 10;
				if (value < 50 && value >= 40)
				{
					result += "XL";
					value -= 40;
					reps = 0;
				}
				value -= (reps * 10);
				while (reps > 0)
				{
					result += "X";
					reps--;
				}
			}
			if (value / 5 != 0)
			{
				reps = value / 5;
				if (value == 9)
				{
					result += "IX";
					value -= 9;
					reps = 0;
				}
				value -= (reps * 5);
				while (reps > 0)
				{
					result += "V";
					reps--;
				}
			}
			if (value / 1 != 0)
			{
				reps = value / 1;
				if (value == 4)
				{
					result += "IV";
					value -= 4;
					reps = 0;
				}
				value -= (reps * 1);
				while (reps > 0)
				{
					result += "I";
					reps--;
				}
			}
		}
		return (result);
	}

	public static DateTime proxDia()
	{
		DateTime d = DateTime.Now.AddDays(1);
		return d;
	}
}