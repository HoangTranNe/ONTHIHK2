using System;

namespace E3
{
    class Program
    {
        /*
         * Các ví dụ từ slide 29 -> 35. 
         * Sử dụng 2 phương pháp: dùng biến out và return
         */

        static void Input2DArray(out int[,] arr)
        {
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Cols: ");
            int cols = int.Parse(Console.ReadLine());

            arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int[,] Input2DArray()
        {
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;
        }

        static void Show(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr;
            Input2DArray(out arr);
            //arr = Input2DArray();
            Show(arr);
        }
    }
}
