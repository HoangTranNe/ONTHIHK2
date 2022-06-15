using System;
using System.Collections.Generic;

namespace E11
{
    class Program
    {
        /*
        * Bài tập 8 (slide bài giảng 1 - trang 45)
        * Viết chương trình đọc và in ra một mảng 2 chiều với số dòng và số lượng 
        * phần tử trên mỗi dòng chưa biết trước.
        * 
        * Input:
        * 5 4 7
        * 1 7 9 0 2
        * 5 7 8 0
        * 7 9
        * end
        * 
        * Output:
        * 5 4 7
        * 1 7 9 0 2
        * 5 7 8 0
        * 7 9
        */
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            bool cont = true;

            while(cont)
            {
                Console.Write("Input: ");
                string userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    cont = false;
                }
                else
                {
                    string[] tokens = userInput.Split();
                    List<int> row = new List<int>();
                    foreach(string token in tokens)
                    {
                        row.Add(int.Parse(token));
                    }
                    arr.Add(row);
                }
            }


            Console.WriteLine("-------------------------");
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    Console.Write("{0} ", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
