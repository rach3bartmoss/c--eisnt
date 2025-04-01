using System;

namespace eisnt
{
	class	CicloFor
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Indique um número:");
			bool	sucess = int.TryParse(Console.ReadLine(), out int n);
			if (!sucess)
			{
				Console.WriteLine("Número inválido");
				return ;
			}

			int	count;
			for (count = 0; 0 <= n; n--)
			{
				if (n % 2 != 0)
					continue ;
				else
					count++;
			}
			Console.WriteLine($"{count}");
		}
	}
}