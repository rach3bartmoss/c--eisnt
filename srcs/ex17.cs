using System;
using System.Data;
using System.Xml.Serialization;


namespace	ex17
{
	
	class ex17
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Quantos dias quer adicionar ao dia de hoje?");
			int dias = int.Parse(Console.ReadLine());

			DateTime d1 = proxDia(dias);
		}
		public static DateTime proxDia()
		{
			DateTime d = DateTime.Now.AddDays(1);
			return d;
		}
	}
}