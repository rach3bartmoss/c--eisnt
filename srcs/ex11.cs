using System;

namespace eisnt
{
	class	Fibonnacci
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Insira valor para calcular série de Fibonacci");
			bool sucess = int.TryParse(Console.ReadLine(), out int n);
			if (!sucess)
			{
				Console.WriteLine("Número inválido");
				return ;
			}

			int	prev;
			int	curr = 1;
			for (prev = 0; prev < n;)
			{
				Console.Write($"{prev} ");
				prev = curr-prev;
				curr += prev;
			}
			Console.Write("\n");
		}
	}
}