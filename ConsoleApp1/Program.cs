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
            int[,] Arr =  { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 },
                           { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };
            PrintMassiv(Arr);
            Console.WriteLine(Arr.Length);
            Swap(Arr);
            PrintMassiv(Arr);

            Console.ReadKey();
        }

        public static void PrintMassiv(int[,] A)
        {
           
            var ran = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {                  
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Swap(int[,] A)
        {
            for (int i = 0, j = A.GetLength(1)/2-1; i < A.GetLength(0) && j < A.GetLength(1) / 2; i++)
            {

                int temp = A[i, j];
                A[i, j] = A[i, j+1];
                A[i, j+1] = temp;
                
            }
            for (int i = 0, j = 0 ; i < A.GetLength(0) && j < A.GetLength(1) ; i++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1)-1];
                A[i, A.GetLength(1) - 1] = temp;
    
            }
        }

    }
}
