using System;
/*escreva um programa para ler o ano de nascimento de uma pessoa e escrever uma mensagem que diga se ela pode votar
este ano, usando DataTime*/
namespace eisnt
{
    class Ex07
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int nascimento = int.Parse(Console.ReadLine());
            if ((now.Year - nascimento) < 18)
            {
                Console.WriteLine($"Não pode votar este ano: {now.Year}");
            }
            else
            {
                Console.WriteLine("Pode votar esse ano");
            }
        }
    }
}
