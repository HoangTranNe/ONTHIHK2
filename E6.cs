using System;

namespace E6
{
    class Program
    {
        /*
        * Bài tập 3 (slide bài giảng 1 - trang 40)
        * Cho một bảng số nguyên a gồm m dòng, n cột. Viết hàm nhận vào bảng a 
        * và tính tổng tất cả các phần tử trong bảng a.
        * 
        * Input: 
        * - Dòng đầu tiên: 2 số nguyên m, n
        * - m dòng tiếp theo: mỗi dòng n số nguyên là giá trị các phần tử trong bảng a
        * 
        * Output: một dòng duy nhất chứa tổng tất cả các phần tử trong bảng a
        * 
        * Input: 
        * 2 3
        * 
        * 5 1 3
        * 4 7 2
        * 
        * Output: 
        * 22
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

        static int Sum(int[,] arr)
        {
            int total = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    total += arr[i, j];
                }    
            }    

            return total;
        }


        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string[] tokens = Console.ReadLine().Split();

            int rows = int.Parse(tokens[0]);
            int cols = int.Parse(tokens[1]);

            int[,] arr = Input2DArray(rows, cols);
            int total = Sum(arr);
            Console.WriteLine("-----------------");
            Console.WriteLine("Total: {0}", total);
        }
    }
}
