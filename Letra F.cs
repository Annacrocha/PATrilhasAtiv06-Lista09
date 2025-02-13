using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] vetNumero1 = new int[5];
			vetNumero1[0] = 5;
			vetNumero1[1] = 7;
			vetNumero1[2] = 9;
			vetNumero1[3] = 15;
			vetNumero1[4] = 18;
			
			int[] vetNumero2 = new int[5];
			vetNumero2[0] = 11;
			vetNumero2[1]= 14;
			vetNumero2[2] = 16;
			vetNumero2[3] = 5;
			vetNumero2[4] = 10;
			
			
			int[] soma = new int[5];
			for (int i = 0; i < 5; i++)
            {
                soma[i] = vetNumero1[i] + vetNumero2[i];
            }

            Console.WriteLine("Vetor soma:");
            for (int i = 0; i < soma.Length; i++)
            {
                Console.WriteLine("Soma do índice {0}: {1}", i, soma[i]);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
				
				
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}

		}
            
}
