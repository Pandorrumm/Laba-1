using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cи_Шарп_ЛР1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =  { { 1, 2, 3,20 }, { 5, 6, 7,21}, { 9, 10, 11 ,22},
                           { 13, 14, 15 ,23}, { 17, 18, 19,24 },{ 20, 21, 22,25 } };
            PrintArray(arr);
            Console.WriteLine(arr.Length);
            Console.WriteLine("массив с заменой столбцов");
            Swap(arr);
            PrintArray(arr);

            Console.ReadKey();
        }

        public static void PrintArray(int[,] Array)
        {
                
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {                  
                    Console.Write("{0}\t", Array[i, j]);
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }

        public static void Swap(int[,] Array)
        {
            int y = Array.GetLength(1);
            if (y % 2 != 0)
            {
                for (int i = 0, j = Array.GetLength(1) / 2; i < Array.GetLength(0) && j < Array.GetLength(1)  ; i++)
                {
                    int temp = Array[i, j-1];
                    Array[i, j-1] = Array[i, j + 1];
                    Array[i, j + 1] = temp;

                }
                for (int i = 0, j = 0; i < Array.GetLength(0) && j < Array.GetLength(1)&& Array.GetLength(1)>3; i++)
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, Array.GetLength(1) - 1];
                    Array[i, Array.GetLength(1) - 1] = temp;
                }     
            }
            else
            {
                for (int i = 0, j = Array.GetLength(1) / 2 - 1; i < Array.GetLength(0) && j < Array.GetLength(1) / 2; i++)
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, j + 1];
                    Array[i, j + 1] = temp;
                }
                for (int i = 0, j = 0; i < Array.GetLength(0) && j < Array.GetLength(1); i++)
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, Array.GetLength(1) - 1];
                    Array[i, Array.GetLength(1) - 1] = temp;
                }
            }
        }
    }
}
