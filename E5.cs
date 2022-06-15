using System;

namespace E5
{
    class Program
    {
        /*
         * Bài tập 2 (slide bài giảng 1 - trang 39)
         * Yêu cầu tương tượng Bài tập 1 (E4) nhưng k là chỉ số cột cần in.
         * 
         * Input: 
         * 4 5 1
         * 
         * 5 4 7 4 7
         * 1 7 9 0 2
         * 5 7 8 0 3 
         * 7 9 3 6 9
         * 
         * Output: 
         * Column 1: 4 7 7 9
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

        static void Show(int[,] arr, int col)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Output: ");
            Console.Write("Column {0}: ", col);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("{0} ", arr[i, col]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string[] tokens = Console.ReadLine().Split();

            int rows = int.Parse(tokens[0]);
            int cols = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);

            int[,] arr = Input2DArray(rows, cols);
            Show(arr, c);
        }
    }
}
