using System;

namespace E1
{
    class Program
    {
        /*
         * Bài tập 1 (slide bài giảng 1 - trang 7) Viết chương trình có các hàm 
         * chức năng sau:
         * 
         * a/ Hàm nhập một mảng số nguyên (bao gồm các thao tác: nhập số lượng 
         * phần tử, khởi tạo mảng và nhập giá trị các phần tử).
         * 
         * b/ Hàm nhập giá trị các phần tử của một mảng số nguyên (mảng đã được 
         * khởi tạo trước khi gọi hàm).
         * 
         * c/ Hàm xuất các giá trị phần tử của 1 mảng số nguyên ra màn hình.
         */

        public static void InputArray(out int[] arr)
        {
            Console.Write("Please enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

        }

        public static int[] InputArray()
        {
            Console.Write("Please enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }


        public static void InputElements(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }    
        }


        public static void Show(int[] arr)
        {
            Console.Write("Arr: ");
            foreach(int e in arr)
            {
                Console.Write("{0} ", e);
            }    
        }


        static void Main(string[] args)
        {
            // Câu a - cách 1 - sử dụng tham số out

            //int[] Arr;
            //InputArray(out Arr);
            //Show(Arr);

            // Câu a - cách 2 - return về mảng int
            //int[] Arr;
            //Arr = InputArray();
            //Show(Arr);

            // Câu b
            Console.Write("Please enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            InputElements(arr);
            Show(arr);
        }
    }
}
