using System;

namespace eisnt
{
	class Program
	{
		static void	Main(string[] args)
		{
			int	day = int.Parse(Console.ReadLine());

			//productClass(day); //warning of unreacheble code after this point
			//return ;

			if (day > 7 || day <= 0)
			{
				Console.WriteLine("Invalid input");
				return ;
			}
			switch (day)
			{
				case 1:
				case 7:
					Console.WriteLine("Esse dia é fim de semana");
					break ;
				default:
					if (day != 1 && day != 7)
					{
						Console.WriteLine("Esse dia é útil");
					}
					break ;
			}
		}

		static void	productClass(int n)
		{
			switch (n)
			{
				case 1:
					Console.WriteLine("Alimento não-perecível");
					break ;
				case 2:
					Console.WriteLine("Alimento perecível");
					break ;
				case 3:
					Console.WriteLine("Vestuário");
					break ;
				case 4:
					Console.WriteLine("Limpeza");
					break ;
				default:
					Console.WriteLine("Categoria desconhecida");
					break ;

			}
		}
	}
}