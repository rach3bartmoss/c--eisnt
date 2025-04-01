using	System;

namespace eisnt
{
	class Ex14
	{
		static void	Main(string[] args)
		{
			Console.WriteLine("Introduza o ano para saber se é bissexto: ");
			int	ano = int.Parse(Console.ReadLine());

			if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
			{
				Console.WriteLine($"O ano {ano} é bissexto");
			}
			else
				Console.WriteLine($"O ano {ano} não é bissexto");
		}
	}
}