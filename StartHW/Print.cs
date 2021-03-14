using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    class Print
    {
        public static void PrintDigit<T>(T a)
        {
            Console.WriteLine(a);
        }

        public static void PrintSingle<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }
        }

        public static void PrintList<T>(List <T> list)
        {
            Console.WriteLine(string.Join(",", list));
        }

        public static void PrintMulty<T>(T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
