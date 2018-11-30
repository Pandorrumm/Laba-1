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
            Console.Write("X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y : ");
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x,y];
            PrintArray(arr);
            Console.WriteLine(arr.Length);
            Console.WriteLine("Массив с заменой столбцов");
            Swap(arr);
            PrintArraySwap(arr);
            Console.ReadKey();
        }

        public static void PrintArray(int[,] Array)
        {
            var rnd = new Random();  
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i,j] = rnd.Next(0, 10);                             
                    Console.Write("{0,1}  ", Array[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintArraySwap(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", Array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Swap(int[,] Array)
        {
         
            for (int j = 0; j < Array.GetLength(1)/2  ; j++)
            {
               for (int i = 0; i < Array.GetLength(0); i++)
               {
                    int temp = Array[i, j];
                    Array[i, j ] = Array[i, Array.GetLength(1)-1-j];
                    Array[i, Array.GetLength(1) - 1 - j] = temp;
               }
            }

        }
    }
}
