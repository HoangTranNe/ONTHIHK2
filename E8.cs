using System;

namespace E8
{
    class Program
    {
        /*
         * Bài tập 5 (slide bài giảng 1 - trang 42)
         * Cho ma trận vuông a kích thước n (mảng 2 chiều có 
         * số dòng = số cột). Viết hàm in ra các phần tử nằm trên đường chéo 
         * chính của a.
         * 
         * Input:
         * - Dòng đầu tiên: số nguyên n
         * - n dòng tiếp theo: mỗi dòng n số nguyên là giá trị các phần tử trong bảng a
         * 
         * Output: một dòng duy nhất chứa cả các phần tử nằm trên đường chéo chính
         * 
         * Input:
         * 3
         * 5 1 3
         * 4 7 2
         * 4 2 6
         * 
         * Output:
         * 5
         * 7
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

        static void PrintMainDiagonal(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("{0}", matrix[i, j]);
                    }    
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            int[,] matrix = Input2DArray(rows, cols);
            PrintMainDiagonal(matrix);
        }
    }
}
