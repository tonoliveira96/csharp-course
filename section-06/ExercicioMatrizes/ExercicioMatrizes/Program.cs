// Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo númeris inteiros.
// Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
namespace ExecicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = new Random().Next(-100,100); 
                }
            }
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " | ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + count);
        }
    }
}

