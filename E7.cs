using System;

namespace E7
{
    class Program
    {
        /*
         * Bài tập 4 (slide bài giảng 1 - trang 41)
         * Viết chương trình quản lý bảng điểm của các sinh viên trong một lớp 
         * học. Bảng điểm bao gồm các môn Toán, Ngữ văn và Tiếng Anh. 
         * Chương trình có thể thực hiện chức năng cơ bản sau:
         * 
         * - Tính điểm TB của từng sinh viên (TB theo từng dòng)
         * - Tính điểm TB của từng môn học (TB theo từng cột)
         * 
         * Input: 
         * 4 3
         * 8 6 7
         * 9 9 8
         * 6 8 10
         * 7 9 5
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

        static float AvgRow(int[,] arr, int row)
        {
            float total = 0;

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                total += arr[row, i];
            }

            return total / arr.GetLength(1);
        }

        static float AvgCol(int[,] arr, int col)
        {
            float total = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                total += arr[i, col];
            }

            return total / arr.GetLength(0);
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string[] tokens = Console.ReadLine().Split();

            int rows = int.Parse(tokens[0]);
            int cols = int.Parse(tokens[1]);

            int[,] arr = Input2DArray(rows, cols);

            int row = 0;
            int col = 1;

            float ar = AvgRow(arr, row);
            Console.WriteLine("AVG Row {0}: {1}", row, ar);

            float ac = AvgCol(arr, col);
            Console.WriteLine("AVG Column {0}: {1}", col, ac);
        }
    }
}
