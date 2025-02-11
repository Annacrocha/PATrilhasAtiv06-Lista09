using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("LISTAGEM ALUNOS\n");
			
			string[] nomesAlunos = new string[5];
			nomesAlunos [0] = "Anna Clara";
			nomesAlunos [1] = "Camille";
			nomesAlunos [2] = "Daniel";
			nomesAlunos [3] = "Gabriel";
			nomesAlunos [4] = "Marcos";
			
			 int[,] notasAlunos = new int[5, 2];
            notasAlunos[0, 0] = 7;
            notasAlunos[0, 1] = 10;
            notasAlunos[1, 0] = 8;
            notasAlunos[1, 1] = 3;
            notasAlunos[2, 0] = 10;
            notasAlunos[2, 1] = 6;
            notasAlunos[3, 0] = 8;
            notasAlunos[3, 1] = 7;
            notasAlunos[4, 0] = 8;
            notasAlunos[4, 1] = 10;
				
			float[] mediaNotas = new float[5];

            for (int i = 0; i < 5; i++)
            {
               
                 mediaNotas[i] = (notasAlunos[i, 0] + notasAlunos[i, 1]) / 2f;
                Console.WriteLine("Aluno: " + nomesAlunos[i],  "Média: " + mediaNotas[i]);
          
			
			
		}
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}
}
}
