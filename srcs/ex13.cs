using	System;

namespace eisnt
{
	class Ex13
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Por favor insira as seguintes informações");
			Console.Write("Nome: ");
			string nome;
			do
			{
				nome = Console.ReadLine().ToLower();
			if (nome.Length < 3)
				Console.WriteLine("Nome menor que 3 caracteres, insira novamente");
			} while (nome.Length < 3);
			Console.Write("Insira idade entre 0 e 100: ");
			bool sucess = uint.TryParse(Console.ReadLine(), out uint idade);
			if (!sucess && idade > 100 || idade < 0)
			{
				Console.WriteLine("Idade inválida");
				return;
			}
			Console.Write("Insira seu sálario: ");
			sucess = int.TryParse(Console.ReadLine(), out int salario);

			if (salario <= 0)
			{
				Console.WriteLine("Salário inválido, valor deve ser positivo");
				return;
			}
			Console.Write("Insira sexo (m/f): ");
			sucess = char.TryParse(Console.ReadLine().ToLower(), out char sexo);
			if (!sucess || sexo != 'm' && sexo != 'f')
			{
				Console.WriteLine("Gênero inválido");
				return;
			}
			Console.Write("Insira estado civil (s/c/v/d): ");
			sucess = char.TryParse(Console.ReadLine().ToLower(), out char estado_civil);
			if (!sucess || (estado_civil != 's' && estado_civil != 'c' && estado_civil != 'v' && estado_civil != 'd'))
			{
				Console.WriteLine("Estado civil inválido, deve inserir 'S','C', 'V' ou 'D'");
				return;
			}
			Console.WriteLine($"\nNome:{nome}\nIdade:{idade}\nSalario:{salario}\nGênero:{sexo}\nEstado Civil:{estado_civil}");
		}
	}
}
