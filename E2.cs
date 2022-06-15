using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        /*
         * Bài tập 2 (slide bài giảng 1 - trang 12) Viết chương trình thực hiện  
         * yêu cầu sau:
         * 
         * a/ Khai báo và khởi tạo một List số nguyên. In ra màn hình giá trị 
         * thuộc tính Count và Capacity của List.
         * 
         * b/ Thêm lần lượt các số nguyên từ 1 đến 10 vào cuối List. Sau mỗi 
         * lượt thêm in ra màn hình giá trị các phần tử hiện có trong List, 
         * các thuộc tính Count và Capacity của List
         * 
         * c/ Lần lượt xóa phần tử ở đầu List cho đến khi hết danh sách. Sau mỗi 
         * lượt xóa in ra màn hình giá trị các phần tử hiện có trong List, 
         * các thuộc tính Count và Capacity của List
         */

        static void Show(List<int> myList)
        {
            Console.Write("List: ");
            foreach(int item in myList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // a
            List<int> myList = new List<int>();

            Console.WriteLine("Count: {0}", myList.Count);
            Console.WriteLine("Capacity: {0}", myList.Capacity);

            Console.WriteLine("--------------------------------");

            // b
            for (int i = 1; i <= 10; i++)
            {
                myList.Add(i);
                Show(myList);
                Console.WriteLine("Count: {0}", myList.Count);
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("********************************");
            }
            Console.WriteLine("--------------------------------");

            // c
            while (myList.Count > 0)
            {
                myList.RemoveAt(0);
                /*
                 * TrimExcess -> Hệ thống sẽ cấp phát lại (cập nhật) vùng nhớ 
                 * (capacity) cho list.
                 */
                // myList.TrimExcess();
                Show(myList);
                Console.WriteLine("Count: {0}", myList.Count);
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("********************************");
            }    

        }
    }
}
