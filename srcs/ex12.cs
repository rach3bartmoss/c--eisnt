using System;

namespace eisnt
{
	class	Ex12
	{
		static void	Main(string[] args)
		{
			bool sucess;
			int	n;
			Console.WriteLine("Enter a number between 0 and 20");
			do
			{
				sucess = int.TryParse(Console.ReadLine(), out n);
				if (!sucess)
				{
					Console.WriteLine("Argument is not a number");
					n = -1;
				}
				else if (n >= 0 && n <= 20)
				{
					Console.WriteLine($"The value {n} is acceptable");
				}
				else
					Console.WriteLine("Please insert a valid number");

			} while (n > 20 || n < 0);
		}
	}
}