using System;

namespace E4
{
    class Program
    {
        /*
         * Bài tập 1 (slide bài giảng 1 - trang 37)
         * Cho một bảng số nguyên a gồm m dòng, n cột. Viết hàm nhận vào bảng a
         * và một số nguyên k, thực hiện in các phần tử trên dòng thứ k 
         * (0 ≤ k < m) ra màn hình.
         * 
         * Input:
         * - Dòng đầu tiên: 3 số nguyên m, n, k 
         * - m dòng tiếp theo: mỗi dòng n số nguyên là giá trị các phần tử 
         * trong bảng a
         * 
         * Output: một dòng duy nhất chứa các phần tử trên dòng thứ k của 
         * bảng a, mỗi phần tử cách nhau bởi dấu khoảng trắng.
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
         * Row 1: 1 7 9 0 2
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

        static void Show(int[,] arr, int row)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Output: ");
            Console.Write("Row {0}: ", row);
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                Console.Write("{0} ", arr[row, i]);
            }    
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string[] tokens = Console.ReadLine().Split();

            int rows = int.Parse(tokens[0]);
            int cols = int.Parse(tokens[1]);
            int r = int.Parse(tokens[2]);

            int[,] arr = Input2DArray(rows, cols);
            Show(arr, r);
        }
    }
}
