using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Vetor de inteiros\n");
			
			int[] numInteiros = new int[7];
			
			numInteiros [0] = 10;
			numInteiros [1] = 15;
			numInteiros [2] = 20;
			numInteiros [3] = 25;
			numInteiros [4] = 30;
			numInteiros [5] = 35;
			numInteiros [6] = 40;
			
			for (int i = 0; i < numInteiros.Length; i++) {
				Console.WriteLine(numInteiros[i]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
