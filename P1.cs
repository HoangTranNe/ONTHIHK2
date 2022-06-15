using System;

namespace P1
{
    class Program
    {
        /*
         * Bài tập 1 - Buổi 1 - Mảng 2 chiều (phần 1) - Trang 1
         * Viết các hàm chức năng để có thể thực hiện đoạn chương trình 
         * sau đây (thực hiện được hàm main):
         */

        static void NhapMang1(out int[,] arr)
        {
            int rows, cols;
            Console.Write("Số dòng: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            cols = int.Parse(Console.ReadLine());

            arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.Write("Dòng {0}: ", i);
                string[] tokens = Console.ReadLine().Split();

                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = int.Parse(tokens[j]);
                }
            }    
        }

        static int[,] NhapMang2()
        {
            int[,] arr;
            int rows, cols;

            Console.Write("Số dòng: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            cols = int.Parse(Console.ReadLine());

            arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.Write("Dòng {0}: ", i);
                string[] tokens = Console.ReadLine().Split();

                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = int.Parse(tokens[j]);
                }
            }

            return arr;
        }

        static void NhapMang3(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("Dòng {0}: ", i);
                string[] tokens = Console.ReadLine().Split();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(tokens[j]);
                }
            }
        }

        static void XuatMang(int[,] arr)
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
            //Console.WriteLine("Nhap mang a:");
            //int[,] a;
            //NhapMang1(out a);
            //Console.WriteLine("Mang a vua nhap:");
            //XuatMang(a);


            //Console.WriteLine("Nhap mang b:");
            //int[,] b;
            //b = NhapMang2();
            //Console.WriteLine("Nhap b vua nhap:");
            //XuatMang(b);


            Console.WriteLine("Nhap mang c:");
            int m, n;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] c = new int[m, n];
            NhapMang3(c);
            Console.WriteLine("Mang c vừa nhập:");
            XuatMang(c);
        }
    }
}
