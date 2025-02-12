using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("VETOR DE NÚMEROS DECIMAIS\n");
			
			decimal[] numDecimal = new decimal [4];
			numDecimal[0] = 14.5m;
			numDecimal[1] = 1.2m;
			numDecimal[2] = 9.3m;
			numDecimal[3] = 10.7m;
			
			float[] mediaNum = new float[4];

            for (int i = 0; i < 4; i++)
            {
               
            	mediaNum[i] = (float)(numDecimal[i] / 2m);
                Console.WriteLine("Média: " + mediaNum[i]);
          
			
		
			
			
		}
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}
}
}
