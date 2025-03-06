using System;

namespace	eisnt
{
	class	Program
	{
		static void	Main(string[] args)
		{
			int[]	arr;

			arr = new int[3];
			for (int i = 0; i <= 2; i++)
			{
				Console.Write($"Enter element {i + 1}: ");
				arr[i] = int.Parse(Console.ReadLine());
			}
			Array.Sort(arr);
			for (int i = 2; i >= 0; i--)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}