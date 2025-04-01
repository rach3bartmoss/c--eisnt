using System;

namespace	eisnt
{
	class	Ex15
	{
		static void	Main(string[] args)
		{
			do {
				Console.WriteLine("Introduza um mês: ");
				int mes = int.Parse(Console.ReadLine());
				switch (mes)
				{
					case 3:
					case 5:
					case 7:
					case 8:
					case 10:
					case 12:
					case 1:
					{
						Console.WriteLine("31 dias");
						break ;
					}
					case 2:
					{
						Console.WriteLine("Para o mês de fevereiro insira o ano: ");
						int ano_corrente = int.Parse(Console.ReadLine());
						if (CheckLeapYear(ano_corrente))
							Console.WriteLine("29 dias");
						else
							Console.WriteLine("28/29 dias");
						break ;
					}
					default:
					{
						if (mes > 12 || mes <= 0)
						{
							Console.WriteLine("Mês inválido");
							break ;
						}
						Console.WriteLine("30 dias");
						break ;
					}
				}

			} while (true);
		}
		static bool	CheckLeapYear(int ano)
		{
			if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
				return (true);
			else
				return (false);
		}
	}
}