using	System;
using	System.Collections.Generic;

namespace	TrabalhoIntermedio
{
	struct	Boletim
	{
		public int		candidato_1;
		public int		candidato_2;
		public int		candidato_3;
		public int		candidato_4;
		public int		votosTotais;
		public string	passwdMestra;
		public int		tentativas;
		public			DateTime	c1;
		public			DateTime	c2;
		public			DateTime	c3;
		public			DateTime	c4;
		public	Boletim(int valorInicial)
		{
			candidato_1 = 0;
			candidato_2 = 0;
			candidato_3 = 0;
			candidato_4 = 0;
			passwdMestra = "987456";
			votosTotais = 0;
			tentativas = 2;
			c1 = DateTime.MinValue;
			c2 = DateTime.MinValue;
			c3 = DateTime.MinValue;
			c4 = DateTime.MinValue;
		}
	}
	class ProgramEleiçoes
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Iniciada as eleições.\n");
			Console.WriteLine("Defina senha da sessão de voto: (presidente de mesa de voto)");

			string	passwdSession = Console.ReadLine();
			if (!string.IsNullOrEmpty(passwdSession))
			{
				Console.WriteLine("Senha definida");
			}
			else
			{
				Console.WriteLine("Senha inválida!");
				return ;
			}

			Console.WriteLine("\nMesa de voto aberta, escolha entre 4 candidatos");
			int	stop_flag = 0;
			int	temp = 0;
			Boletim	listaDeCandidatos = new Boletim(0);
			while (temp == 0)
			{
				temp = init_pool(stop_flag, ref listaDeCandidatos, passwdSession);
			}
			anuncio(ref listaDeCandidatos);
		}

		static public int	init_pool(int stop_flag, ref Boletim listaDeCandidatos, string passwdSession)
		{
			string	voto = "";
			Console.WriteLine("Para encerar a votação insira '0'");
			while (voto != "0")
			{
				Console.WriteLine("Insira pin do candidato que desejar votar: (001 / 002 / 003 / 004)");
				voto = Console.ReadLine();
				incrementVotes(voto, ref listaDeCandidatos);
			}
			if (voto == "0")
			{
				encerrarVotação(passwdSession, ref listaDeCandidatos);
				return 1;
			}
			return 1;
		}

		static public void	incrementVotes(string voto, ref Boletim listaDeCandidatos)
		{
			if (voto == "001")
			{
				listaDeCandidatos.candidato_1 += 1;
				listaDeCandidatos.votosTotais += 1;
				listaDeCandidatos.c1 = DateTime.Now;
				Console.WriteLine("Voto contabilizado.");
				return ;
			}
			else if (voto == "002")
			{
				listaDeCandidatos.candidato_2 += 1;
				listaDeCandidatos.votosTotais += 1;
				listaDeCandidatos.c2 = DateTime.Now;
				Console.WriteLine("Voto contabilizado.");
				return ;
			}
			else if (voto == "003")
			{
				listaDeCandidatos.candidato_3 += 1;
				listaDeCandidatos.votosTotais += 1;
				listaDeCandidatos.c3 = DateTime.Now;
				Console.WriteLine("Voto contabilizado.");
				return ;
			}
			else if (voto == "004")
			{
				listaDeCandidatos.candidato_4 += 1;
				listaDeCandidatos.votosTotais += 1;
				listaDeCandidatos.c4 = DateTime.Now;
				Console.WriteLine("Voto contabilizado.");
				return ;
			}
			else if (voto == "0")
			{
				Console.WriteLine("Finalizando votação ...");
				return ;
			}
			else
			{
				Console.WriteLine("Voto inválido, insira pin novamente");
				return ;
			}
		}

		static public void	encerrarVotação(string passwdSession, ref Boletim listaDeCandidatos)
		{
			Console.WriteLine("\nInsira senha definida no inicio para encerrar mesa de voto.");
			while (true)
			{
				string resp2 = Console.ReadLine();
				if (listaDeCandidatos.tentativas == 0)
				{
					Console.WriteLine($"Numero de tentativas excedido, insira chave mestra {listaDeCandidatos.passwdMestra}");
					resp2 = Console.ReadLine();
					while(resp2 != listaDeCandidatos.passwdMestra)
					{
						Console.WriteLine("Insira chave mestra novamente");
						resp2 = Console.ReadLine();
					}
					break ;
				}
				if (resp2 != passwdSession || (listaDeCandidatos.tentativas > 2 && listaDeCandidatos.tentativas < 1))
				{
					Console.WriteLine($"Insira senha novamente {listaDeCandidatos.tentativas} tentativas restantes.");
					listaDeCandidatos.tentativas -= 1;
				}
				else if (resp2 == passwdSession)
				{
					Console.WriteLine("Votação encerrada\n");
					break ;
				}
				else
				{
					Console.WriteLine("if you got here, is a error");
					break ;
				}
			}
		}

		static public void	anuncio(ref Boletim listaDeCandidatos)
		{
			int[]	votos = { listaDeCandidatos.candidato_1, listaDeCandidatos.candidato_2, listaDeCandidatos.candidato_3, listaDeCandidatos.candidato_4};
			int		maxVotos = votos[0];

			for (int i = 1; i < votos.Length; i++)
			{
				if (votos[i] > maxVotos)
					maxVotos = votos[i];
			}
			List<int> candidatosEmpatados = new List<int>();
			for (int i = 0; i < votos.Length; i++)
			{
				if (votos[i] == maxVotos)
					candidatosEmpatados.Add(i);
			}
			int candidatoVencedor;
			if (candidatosEmpatados.Count > 1)
			{
				candidatoVencedor = resolverEmpate(ref listaDeCandidatos);
				Console.WriteLine($"Empate detectado! Desempate efetuado.\nCandidato {candidatoVencedor} vencedor das eleições após desempate!");
			}
			else
			{
				candidatoVencedor = candidatosEmpatados[0] + 1;
			}
			Console.WriteLine($"Candidato vencedor com mais votos: Candidato {candidatoVencedor} com {maxVotos} votos.");
			Console.WriteLine($"Com uma percentagem de {(maxVotos * 100) / listaDeCandidatos.votosTotais}%");
			Console.WriteLine("\nPorcentagem de votos por candidato:");
			for (int i = 0; i < votos.Length; i++)
			{
				double porcentagem = (double)votos[i] / listaDeCandidatos.votosTotais * 100;
				Console.WriteLine($"Candidato {i + 1}: {votos[i]}({porcentagem:F2}%)");
			}
		}

		static public int	resolverEmpate(ref Boletim listaDeCandidatos)
		{
			int[]	votos = {
				listaDeCandidatos.candidato_1,
				listaDeCandidatos.candidato_2,
				listaDeCandidatos.candidato_3,
				listaDeCandidatos.candidato_4
			};

			DateTime[]	tempos = {
				listaDeCandidatos.c1,
				listaDeCandidatos.c2,
				listaDeCandidatos.c3,
				listaDeCandidatos.c4
			};
			int	maxVotos = votos[0];
			
			for (int i = 1; i < votos.Length; i++)
			{
				if (votos[i] > maxVotos)
					maxVotos = votos[i];
			}
			List<int> candidatosEmpatados = new List<int>();
			for (int i = 0; i < votos.Length; i++)
			{
				if (votos[i] == maxVotos)
					candidatosEmpatados.Add(i);
			}
			if (candidatosEmpatados.Count == 1)
			{
				return candidatosEmpatados[0] + 1;
			}
			else
			{
				int	candidatoVencedor = candidatosEmpatados[0];
				DateTime	tempoVencedor = tempos[candidatoVencedor];
				foreach (int indice in candidatosEmpatados)
				{
					if (tempos[indice] != DateTime.MinValue &&
						(tempoVencedor == DateTime.MinValue || tempos[indice] < tempoVencedor))
					{
						tempoVencedor = tempos[indice];
						candidatoVencedor = indice;
					}
				}
				return (candidatoVencedor + 1);
			}
		}
	}
}