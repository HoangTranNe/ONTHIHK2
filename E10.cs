using System;

namespace E10
{
    class Program
    {
        /*
        * Bài tập 7 (slide bài giảng 1 - trang 44)
        * Cho ma trận vuông a tương tự Bài tập 5. Viết hàm in ra các phần tử
        * thuộc tam giác trên đường chéo chính của a.
        * 
        * Input:
        * 3
        * 5 1 3
        * 4 7 2
        * 4 2 6
        * 
        * Output:
        * 5 1 3
        * 7 2
        * 6
        */

        static int[,] Input2DArray(int rows, int cols)
        {
            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.Write("Row {0}: ", i);
                string[] tokens = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = int.Parse(tokens[j]);
                }
            }

            return arr;
        }
    
        static void PrintUpperTriangularMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            int[,] matrix = Input2DArray(rows, cols);
            PrintUpperTriangularMatrix(matrix);
        }
    }
}
