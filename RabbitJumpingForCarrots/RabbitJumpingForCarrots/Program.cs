using System.Reflection.Metadata;

namespace RabbitJumpingForCarrots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine()!;
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int jumps = 0;

            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == '-')
                        {
                            continue;
                        }
                        if (matrix[i, j] == 'c')
                        {
                            matrix[i, j] = '-';
                            if (i + 1 >= matrix.GetLength(0) || j + 1 > matrix.GetLength(1))
                            {
                                continue;
                            }
                            i = i + 1;
                            j = j + 1;
                        }
                    }
                }

                jumps++;

                int interim = 0;
                foreach (char c in matrix) 
                {
                    
                    if (c == 'c')
                    {
                        interim++;
                    }
                }
                if (interim == 0)
                {
                    break;
                }
            }

            Console.WriteLine(jumps);




        }
    }
}