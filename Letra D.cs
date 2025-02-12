using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("VETOR NÚMERO MAIOR\n");
			
			int[] numero = new int[4];
			numero[0] = 15;
			numero[1] = 47;
			numero [2] = 2;
			numero[3] = 10;
			
			 int maiorNumero = numero[0];  
            
            for (int i = 1; i < numero.Length; i++)  
            {
                if (numero[i] > maiorNumero)
                {
                    maiorNumero = numero[i];
                }
            }

            
            Console.WriteLine("O maior número no vetor é: " + maiorNumero);
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}

		}
            
}
